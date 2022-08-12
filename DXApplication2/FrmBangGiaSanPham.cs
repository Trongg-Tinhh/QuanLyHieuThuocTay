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
        private bool add = false;
        private bool edit = false;
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
            //txtNgay.DateTime = DateTime.Now;
        }

        private void CellClick_SanPham(object sender, DataGridViewCellEventArgs e)
        {
            String MaSP = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString().Trim() ;
            bangGiaTableAdapter.FillByMaSP(this.quanLyHieuThuocTayDataSet.BangGia,MaSP);
            if(this.add)
            {
                nudGiaBan.Enabled = true;
                btnLuu.Enabled = true;
                txtMaSP.Text = MaSP;
                txtTenSP.Text = dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString().Trim();
                cmbMaLoai.SelectedValue = dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString().Trim();
                cmbNhaSX.SelectedValue = dataGridViewSanPham.CurrentRow.Cells[3].Value.ToString().Trim();
            }    
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.add = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.BackColor = SystemColors.ButtonFace;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            if(this.add)
            {
                this.add = false;
                btnThem.Enabled = true;
                nudGiaBan.Enabled = false;
                btnThem.BackColor = Color.DarkGray;
            }   
            if(this.edit)
            {
                this.edit = false;
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            DateTime Ngay = DateTime.ParseExact(txtNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            using (SqlConnection connection = new SqlConnection(DataConnection.DataConnectionString.ConnectionString))
            {
                if(connection.State != ConnectionState.Open)
                    connection.Open();
                String query = @"select * from BangGia where BangGia.maSP = @maSP and BangGia.ngay = @ngay";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text);
                //cmd.Parameters.AddWithValue("@ngay", DateTime.ParseExact(txtNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToString();
                cmd.Parameters.AddWithValue("@ngay",Ngay).ToString();
                SqlDataReader reader= cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Không thể thêm giá SP do trùng khóa");
                }   
                else
                {
                    bangGiaTableAdapter.InsertQueryGiaSanPham( txtMaSP.Text, Ngay, Decimal.Parse( nudGiaBan.Value.ToString()));
                    MessageBox.Show("Đã thêm giá cho sản phẩm có mã: " + txtMaSP.Text.Trim());
                }    

            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}