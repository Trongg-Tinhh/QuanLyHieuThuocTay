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
                        MessageBox.Show("Đã thêm sách " + txtTenSP.Text.Trim());
                    }    

                    connection.Close();
                }

            }    
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.ResumeBinding();
            dataGridViewThuoc.AllowUserToAddRows = true;
            dataGridViewThuoc.AllowUserToDeleteRows = true;
            btnSua.BackColor = System.Drawing.Color.Blue;
            btnHuy.BackColor = System.Drawing.Color.Red;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.ResumeBinding();
            dataGridViewThuoc.AllowUserToAddRows = false;
            dataGridViewThuoc.AllowUserToDeleteRows = false;
            btnSua.BackColor = Color.DarkGray;
            btnHuy.BackColor = Color.DarkGray;
        }
    }
}