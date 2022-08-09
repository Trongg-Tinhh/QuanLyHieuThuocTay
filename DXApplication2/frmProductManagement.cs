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
        private bool edit = false;
        String StringConnect = @"Data Source=TRANNGHIEP;Initial Catalog=QuanLyHieuThuocTay;Integrated Security=True";
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenSP.Text.Trim().CompareTo("") != 0 && edit == false)
            {
                
                Random random = new Random();
                String MaThuoc = random.Next(100,999).ToString() + cmbLoaiSP.SelectedValue.ToString() + cmbMaNSX.SelectedValue.ToString();
                using( SqlConnection connection = new SqlConnection(StringConnect) )
                {
                    if(connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    String query = "SELECT * FROM SanPham WHERE (SanPham.tenSP = @tenSP)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        MessageBox.Show("Thuốc "+ txtTenSP.Text.Trim()+" đã tồn tại");
                        sanPhamTableAdapter.UpdateQuerySoLuongThuoc(int.Parse(nudSoLuong.Value.ToString()), txtTenSP.Text.Trim());
                        danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);

                    }   
                    else
                    {
                        sanPhamTableAdapter.InsertQuerySanPham(MaThuoc, txtTenSP.Text.Trim(), cmbLoaiSP.SelectedValue.ToString(),int.Parse(cmbMaNSX.SelectedValue.ToString()), txtThanhPhan.Text, txtDoTuoi.Text, txtCongDung.Text, cmbDonVi.Text, int.Parse(nudSoLuong.Value.ToString()), txtMoTa.Text);
                        MessageBox.Show("Đã thêm " + txtTenSP.Text.Trim());
                        danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
                    }
                    
                    connection.Close();
                }

            }    
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            //sanPhamBindingSource.ResumeBinding();
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.BackColor = System.Drawing.Color.Blue;
            btnHuy.BackColor = System.Drawing.Color.Red;
            this.edit = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //sanPhamBindingSource.SuspendBinding();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.BackColor = Color.DarkGray;
            btnHuy.BackColor = Color.DarkGray;
            this.edit = false;
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
                if(reader.Read())
                {
                    MessageBox.Show("Thuốc có Mã: " + maSP + " đã tồn tại trong hóa đơn\n  không thể xóa");
                }
                else
                {
                    sanPhamTableAdapter.DeleteQuerySanPhamByMaSP(maSP);
                    MessageBox.Show("Đã xóa thuốc có Mã: " + maSP);
                    danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
                }    
                connection.Close();
            }
        }

        private void SelectionChanged_RowInDataGridViewThuoc(object sender, EventArgs e)
        {
            if (dataGridViewThuoc.SelectedRows.Count > 0 && edit == true)
            {
                btnXoa.Enabled = true;
            }
            else
                btnXoa.Enabled = false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã cập nhật dữ liệu");
            String maSP = dataGridViewThuoc.CurrentRow.Cells[0].Value.ToString();
            //String MaSP = sanPhamTableAdapter.ScalarQueryMaSanPham(txtTenSP.Text.Trim()).ToString();
            String MaLoai = loaiSanPhamTableAdapter.ScalarQueryMaLoaiSanPham(cmbLoaiSP.Text.Trim());
            Nullable<int> MaNSX = nhaSanXuatTableAdapter.ScalarQueryMaNSX(cmbMaNSX.Text.Trim());
            sanPhamTableAdapter.UpdateQuerySanPham(maSP, txtTenSP.Text, MaLoai, MaNSX, txtThanhPhan.Text, txtDoTuoi.Text, txtCongDung.Text, cmbDonVi.Text,int.Parse( nudSoLuong.Value.ToString()), txtMoTa.Text);
            //frmProductManagement frmProductManagement = new frmProductManagement();
            //frmProductManagement.InitializeComponent();
            danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
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
            if (txtTenSP.Text.CompareTo("") != 0)
                btnThem.Enabled = true;
            else
                btnThem.Enabled = false;
        }

        private void CellClick_dataGridViewSanPham(object sender, DataGridViewCellEventArgs e)
        {  
            if(this.edit == true)
            {
                int pos = e.RowIndex;
                String TenSP = dataGridViewThuoc.Rows[pos].Cells[1].Value.ToString();
                String LoaiSP = dataGridViewThuoc.Rows[pos].Cells[3].Value.ToString();
                String NhaSX = dataGridViewThuoc.Rows[pos].Cells[10].Value.ToString();
                String ThanhPhan = dataGridViewThuoc.Rows[pos].Cells[5].Value.ToString();
                String CongDung = dataGridViewThuoc.Rows[pos].Cells[4].Value.ToString();
                String DonViTinh = dataGridViewThuoc.Rows[pos].Cells[8].Value.ToString();
                String MoTa = dataGridViewThuoc.Rows[pos].Cells[11].Value.ToString();
                String DoTuoi = dataGridViewThuoc.Rows[pos].Cells[6].Value.ToString();
                txtTenSP.Text = TenSP;
                cmbMaNSX.Text = NhaSX;
                cmbLoaiSP.Text = LoaiSP;
                txtThanhPhan.Text = ThanhPhan;
                txtCongDung.Text = CongDung;
                cmbDonVi.Text = DonViTinh;
                txtDoTuoi.Text = DoTuoi;
                txtMoTa.Text = MoTa;
            }    
        }
    }
}