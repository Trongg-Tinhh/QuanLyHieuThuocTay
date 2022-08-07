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
            if(txtTenSP.Text.Trim().CompareTo("") != 0)
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
                        MessageBox.Show("Sách "+ txtTenSP.Text.Trim()+" đã tồn tại");
                        sanPhamTableAdapter.UpdateQuerySoLuongThuoc(int.Parse(nudSoLuong.Value.ToString()), txtTenSP.Text.Trim());
                        
                    }   
                    else
                    {
                        sanPhamTableAdapter.InsertQuerySanPham(MaThuoc, txtTenSP.Text.Trim(), cmbLoaiSP.SelectedValue.ToString(),int.Parse(cmbMaNSX.SelectedValue.ToString()), txbThanhPhan.Text, txbDoTuoi.Text, txtCongDung.Text, cmbDonVi.Text, int.Parse(nudSoLuong.Value.ToString()), txbMoTa.Text);
                        MessageBox.Show("Đã thêm " + txtTenSP.Text.Trim());
                        load_Data();
                    }
                    
                    connection.Close();
                }
            }    
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.ResumeBinding();
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            btnSua.BackColor = System.Drawing.Color.Blue;
            btnHuy.BackColor = System.Drawing.Color.Red;
            this.edit = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.SuspendBinding();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
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
                    load_Data();
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
        private void load_Data()
        {
            sanPhamTableAdapter.Fill(quanLyHieuThuocTayDataSet.SanPham);
            dataGridViewThuoc.DataSource = quanLyHieuThuocTayDataSet.SanPham;
            dataGridViewThuoc.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã cập nhật dữ liệu");
            sanPhamTableAdapter.Update(this.quanLyHieuThuocTayDataSet.SanPham);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}