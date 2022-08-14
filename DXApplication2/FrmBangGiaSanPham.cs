using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication2
{
    public partial class FrmBangGiaSanPham : DevExpress.XtraEditors.XtraForm
    {
        public FrmBangGiaSanPham()
        {
            InitializeComponent();
        }
        private bool add = false;     // true: đang ở chức năng thêm  
        private bool edit = false;  //false: đang ở chức năng sửa
        private void ToggleButton(Button b, bool enable)
        {
            b.Enabled = enable;

            if (enable)
                b.BackColor = SystemColors.ActiveBorder;
            else
                b.BackColor = SystemColors.ButtonFace;
        }
        private void DefaultState()
        {
            ToggleButton(btnThem, true);
            ToggleButton(btnSua, true);
            ToggleButton(btnLuu, false);
            ToggleButton(btnHuy, false);
            ToggleButton(btnThoat, true);
        }
        private void FrmBangGiaSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.NhaSanXuat' table. You can move, or remove it, as needed.
            this.nhaSanXuatTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.NhaSanXuat);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.LoaiSanPham);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.BangGia' table. You can move, or remove it, as needed.
            this.bangGiaTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.BangGia);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.SanPham);
            dataGridViewSanPham.ClearSelection();
            dataGridViewBangGia.ClearSelection();

            cmbMaLoai.SelectedItem = null;
            cmbMaLoai.Text = "";

            cmbNhaSX.SelectedItem = null;
            cmbNhaSX.Text = "";
            DefaultState();
        }

        private void CellClick_SanPham(object sender, DataGridViewCellEventArgs e)
        {
            ToggleButton(btnHuy, true);
            
            String MaSP = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString().Trim() ;
            bangGiaTableAdapter.FillByMaSP(this.quanLyHieuThuocTayDataSet.BangGia,MaSP);
            txtMaSP.Text = MaSP;
            txtTenSP.Text = dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
            cmbMaLoai.SelectedValue = dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbNhaSX.SelectedValue = dataGridViewSanPham.CurrentRow.Cells[3].Value.ToString().Trim();

            dataGridViewSanPham.Enabled = false;
            txtTenSP.Enabled = false;
            if (this.add)  // khi thực hiện chức năng thêm
            {
                nudGiaBan.Enabled = true;
                txtNgay.Enabled = true;
                ToggleButton(btnLuu, true);
                txtMaSP.Text = MaSP;
                dataGridViewBangGia.ClearSelection();
            }
            if(this.edit)  // khi thực hiện chức năng sửa
            {
                nudGiaBan.Enabled = true;
                ToggleButton(btnLuu, true);
                txtNgay.Enabled = false;
                txtMaSP.Text = MaSP;
                String checkBangGia = bangGiaTableAdapter.ScalarQueryBangGiaByMaSP(MaSP);
                if (checkBangGia != null)
                {
                    txtNgay.DateTime = DateTime.Parse(dataGridViewBangGia.Rows[0].Cells[1].Value.ToString().Trim());
                    nudGiaBan.Value = int.Parse(dataGridViewBangGia.Rows[0].Cells[2].Value.ToString().Trim().Replace(".000", ""));
                }
                else
                {
                    MessageBox.Show("Sản phẩm bạn vừa chọn chưa có giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewSanPham.ClearSelection();
                }
            }
        }
        private void CellClick_BangGia(object sender, DataGridViewCellEventArgs e)
        {
            if(this.edit)
            {
                txtNgay.DateTime = DateTime.Parse( dataGridViewBangGia.CurrentRow.Cells[1].Value.ToString().Trim());
                nudGiaBan.Value = int.Parse( dataGridViewBangGia.CurrentRow.Cells[2].Value.ToString().Trim().Replace(".000",""));
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.add = true;

            ToggleButton(btnThem, false);
            ToggleButton(btnSua, false);
            ToggleButton(btnHuy, true);

            dataGridViewBangGia.ClearSelection();
            dataGridViewSanPham.ClearSelection();

            dataGridViewBangGia.Enabled = true;
            dataGridViewSanPham.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.edit = true;

            ToggleButton(btnSua, false);
            ToggleButton(btnThem, false);
            ToggleButton(btnHuy, true);

            dataGridViewBangGia.ClearSelection();
            dataGridViewSanPham.ClearSelection();

            dataGridViewBangGia.Enabled = true;
            dataGridViewSanPham.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ToggleButton(btnHuy, false);
            ToggleButton(btnLuu, false);
            ToggleButton(btnThem, true);
            ToggleButton(btnSua, true);

            dataGridViewSanPham.Enabled = true;
            txtTenSP.Enabled = true;

            if (this.add)
            {
                this.add = false;

                nudGiaBan.Enabled = false;
                txtNgay.Enabled = false;
            }   
            if(this.edit)
            {
                this.edit = false;
                nudGiaBan.Enabled = false;
            }

            
            bangGiaTableAdapter.Fill(quanLyHieuThuocTayDataSet.BangGia);
            nudGiaBan.Value = 0;
            txtNgay.DateTime = DateTime.Now;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cmbMaLoai.SelectedItem = null;
            cmbMaLoai.Text = "";
            cmbNhaSX.SelectedItem = null;
            cmbNhaSX.Text = "";

            dataGridViewBangGia.ClearSelection();
            dataGridViewSanPham.ClearSelection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nudGiaBan.Value > 0)
            {
                DateTime Ngay = DateTime.ParseExact(txtNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                using (SqlConnection connection = new SqlConnection(DataConnection.DataConnectionString.ConnectionString))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    
                    if (this.add == true && nudGiaBan.Value > 0)    // Lưu khi đang thực hiện chức năng thêm
                    {
                        String query = @"select * from BangGia where BangGia.maSP = @maSP and BangGia.ngay = @ngay";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text);
                        //cmd.Parameters.AddWithValue("@ngay", DateTime.ParseExact(txtNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToString();
                        cmd.Parameters.AddWithValue("@ngay", Ngay).ToString();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())      // kiểm tra dữ liệu nhập có bị trùng khóa không
                        {
                            MessageBox.Show("Giá đã có, hãy sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else    // thêm sp nếu không trùng khóa
                        {
                            bangGiaTableAdapter.InsertQueryGiaSanPham(txtMaSP.Text, Ngay, Decimal.Parse(nudGiaBan.Value.ToString()));
                            MessageBox.Show("Đã thêm giá cho sản phẩm có mã: " + txtMaSP.Text.Trim());
                            bangGiaTableAdapter.FillByMaSP(quanLyHieuThuocTayDataSet.BangGia, txtMaSP.Text);
                        }
                    }

                    if(this.edit == true && nudGiaBan.Value > 0)
                    {
                        bangGiaTableAdapter.UpdateQueryBangGia(Decimal.Parse(nudGiaBan.Value.ToString()), txtMaSP.Text, txtNgay.Text.Trim());
                        MessageBox.Show("Đã sửa giá cho sản phẩm có mã: " + txtMaSP.Text.Trim());
                        bangGiaTableAdapter.FillByMaSP(quanLyHieuThuocTayDataSet.BangGia, txtMaSP.Text);
                        nudGiaBan.Value = 0;
                    }    
                }
                dataGridViewBangGia.ClearSelection();
            } 
            else
            {
                MessageBox.Show("Giá bán phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudGiaBan.Value = 0;
                txtNgay.DateTime = DateTime.Now;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillEvent_TenSP(object sender, EventArgs e)
        {
            sanPhamTableAdapter.FillByTenSP(this.quanLyHieuThuocTayDataSet.SanPham, txtTenSP.Text);
        }
    }
}