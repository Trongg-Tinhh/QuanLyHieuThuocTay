using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DXApplication2
{
    public partial class frmProductManagement : DevExpress.XtraEditors.XtraForm
    {
        public frmProductManagement()
        {
            InitializeComponent();
        }
        private bool add = false;
        private bool edit = false;
        String StringConnect = DataConnection.DataConnectionString.ConnectionString;
        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.SanPham);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.LoaiSanPham' table. You can move, or remove it, as needed.
            this.loaiSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.LoaiSanPham);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.NhaSanXuat' table. You can move, or remove it, as needed.
            this.nhaSanXuatTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.NhaSanXuat);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.DanhSachSanPham' table. You can move, or remove it, as needed.
            this.danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);

            sanPhamBindingSource.SuspendBinding();
            dataGridViewThuoc.AllowUserToAddRows = false;
            dataGridViewThuoc.AllowUserToDeleteRows = false;
            ChucNang(false);
        }

        private void ChucNang(bool chucnang)
        {
            txtTenSP.Enabled = chucnang;
            txtThanhPhan.Enabled = chucnang;
            nudSoLuong.Enabled = chucnang;
            cmbLoaiSP.Enabled = chucnang;
            txtCongDung.Enabled = chucnang;
            cmbDonVi.Enabled = chucnang;
            cmbMaNSX.Enabled = chucnang;
            txtDoTuoi.Enabled = chucnang;
            txtMoTa.Enabled = chucnang;

        }

        private void setTextNull()
        {
            txtTenSP.Text = "";
            txtThanhPhan.Text = "";
            nudSoLuong.Value = 1;
            txtCongDung.Text = "";
            cmbDonVi.Text = "";
            txtDoTuoi.Text = "";
            txtMoTa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.add = true;
            ChucNang(true);
            btnThem.Enabled = false;
            btnThem.BackColor = SystemColors.ButtonFace;
            btnSua.Enabled = false;
            btnSua.BackColor = SystemColors.ButtonFace;
            btnHuy.Enabled = true;
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnLuu.BackColor = SystemColors.ButtonFace;
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            dataGridViewThuoc.ClearSelection();
            ChucNang(true);
            btnThem.Enabled = false;
            btnThem.BackColor = SystemColors.ButtonFace;
            btnHuy.Enabled = true;
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnSua.Enabled=false;
            btnSua.BackColor = SystemColors.ButtonFace;
            this.edit = true;
            btnLuu.BackColor = SystemColors.ButtonFace;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ChucNang(false);
            if (this.add == true)
            {
                setTextNull();
                btnThem.Enabled = true;
                btnThem.BackColor = SystemColors.ActiveBorder;
                btnSua.Enabled = true;
                btnSua.BackColor = SystemColors.ActiveBorder;
                btnHuy.Enabled = false;
                btnHuy.BackColor = SystemColors.ButtonFace;
                this.add = false;
                
            }
            if (this.edit == true)
            {
                setTextNull();
                btnThem.Enabled = true;
                btnThem.BackColor = SystemColors.ActiveBorder;
                btnSua.Enabled = true;
                btnSua.BackColor = SystemColors.ActiveBorder;
                btnHuy.Enabled = false;
                btnHuy.BackColor = SystemColors.ButtonFace;
                btnLuu.Enabled = false;
                btnLuu.BackColor = SystemColors.ButtonFace;
                this.edit = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            String maSP = dataGridViewThuoc.CurrentRow.Cells[0].Value.ToString().Trim();
            using (SqlConnection connection = new SqlConnection(StringConnect))
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                String query = "select * from ChiTietHoaDon where ChiTietHoaDon.maSP = @maSP";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maSP", maSP);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Thuốc có Mã: " + maSP + " đã tồn tại trong hóa đơn\n  không thể xóa");
                }
                else
                {
                    sanPhamTableAdapter.DeleteQuerySanPhamByMaSanPham(maSP);
                    MessageBox.Show("Đã xóa thuốc có Mã: " + maSP);
                    danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
                }
                connection.Close();
            }
            setTextNull();
        }

        private void SelectionChanged_RowInDataGridViewThuoc(object sender, EventArgs e)
        {
            //if( this.edit == true)
            //{
            //    if (dataGridViewThuoc.SelectedRows.Count > 0)
            //        btnXoa.Enabled = true;
            //    else
            //        btnXoa.Enabled = false;
            //}    

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.add == true)
            {
                if (txtTenSP.Text.Trim().CompareTo("") != 0 && edit == false)
                {

                    Random random = new Random();
                    String MaThuoc = random.Next(100, 999).ToString() + cmbLoaiSP.SelectedValue.ToString() + cmbMaNSX.SelectedValue.ToString();
                    using (SqlConnection connection = new SqlConnection(StringConnect))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        String query = "SELECT * FROM SanPham WHERE (SanPham.tenSP = @tenSP)";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text.Trim());
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Thuốc " + txtTenSP.Text.Trim() + " đã tồn tại");
                            sanPhamTableAdapter.UpdateQuerySoLuongThuoc(int.Parse(nudSoLuong.Value.ToString()), txtTenSP.Text.Trim());
                            danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);

                        }
                        else
                        {
                            sanPhamTableAdapter.InsertQuerySanPham(MaThuoc.Replace(" ", ""), txtTenSP.Text.Trim(), cmbLoaiSP.SelectedValue.ToString(), int.Parse(cmbMaNSX.SelectedValue.ToString()), txtThanhPhan.Text, txtDoTuoi.Text, txtCongDung.Text, cmbDonVi.Text, int.Parse(nudSoLuong.Value.ToString()), txtMoTa.Text);
                            MessageBox.Show("Đã thêm " + txtTenSP.Text.Trim());
                            danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
                        }

                        connection.Close();
                    }

                }
            }
            if (this.edit == true)
            {
                dataGridViewThuoc.ClearSelection();
                MessageBox.Show("Đã cập nhật dữ liệu");
                String maSP = dataGridViewThuoc.CurrentRow.Cells[0].Value.ToString();
                String MaLoai = loaiSanPhamTableAdapter.ScalarQueryMaLoaiSanPham(cmbLoaiSP.Text.Trim());
                Nullable<int> MaNSX = nhaSanXuatTableAdapter.ScalarQueryMaNSX(cmbMaNSX.Text.Trim());
                sanPhamTableAdapter.UpdateQuerySanPham(maSP, txtTenSP.Text, MaLoai, MaNSX, txtThanhPhan.Text, txtDoTuoi.Text, txtCongDung.Text, cmbDonVi.Text, int.Parse(nudSoLuong.Value.ToString()), txtMoTa.Text);

            }
            danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
            setTextNull();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextChanged_TenSanPham(object sender, EventArgs e)
        {
            if (this.add == true)
            {
                if (txtTenSP.Text.Trim().CompareTo("") != 0)
                {
                    btnLuu.Enabled = true;
                    btnLuu.BackColor = SystemColors.ActiveBorder;
                    //btnHuy.Enabled = true;
                }
                else
                {
                    btnLuu.Enabled = false;
                    btnLuu.BackColor = SystemColors.ButtonFace;

                    //btnHuy.Enabled = false;
                }
            }

        }

        private void CellClick_dataGridViewSanPham(object sender, DataGridViewCellEventArgs e)
        {
            if (this.edit == true)
            {
                btnLuu.Enabled = true;
                btnLuu.BackColor = SystemColors.ActiveBorder;
                int pos = e.RowIndex;
                String TenSP = dataGridViewThuoc.Rows[pos].Cells[1].Value.ToString();
                String LoaiSP = dataGridViewThuoc.Rows[pos].Cells[3].Value.ToString();
                String NhaSX = dataGridViewThuoc.Rows[pos].Cells[10].Value.ToString();
                String ThanhPhan = dataGridViewThuoc.Rows[pos].Cells[5].Value.ToString();
                String CongDung = dataGridViewThuoc.Rows[pos].Cells[4].Value.ToString();
                String DonViTinh = dataGridViewThuoc.Rows[pos].Cells[8].Value.ToString();
                String MoTa = dataGridViewThuoc.Rows[pos].Cells[11].Value.ToString();
                String DoTuoi = dataGridViewThuoc.Rows[pos].Cells[6].Value.ToString();
                int SoLuong = int.Parse(dataGridViewThuoc.Rows[pos].Cells[7].Value.ToString());
                txtTenSP.Text = TenSP;
                cmbMaNSX.Text = NhaSX;
                cmbLoaiSP.Text = LoaiSP;
                txtThanhPhan.Text = ThanhPhan;
                txtCongDung.Text = CongDung;
                cmbDonVi.Text = DonViTinh;
                txtDoTuoi.Text = DoTuoi;
                txtMoTa.Text = MoTa;
                nudSoLuong.Value = SoLuong;
            }
        }
    }
}