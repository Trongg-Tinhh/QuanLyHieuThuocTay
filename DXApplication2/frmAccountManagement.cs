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

namespace DXApplication2
{
    public partial class frmAccountManagement : DevExpress.XtraEditors.XtraForm
    {
        public frmAccountManagement()
        {
            InitializeComponent();
            defaultstate();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
        }

        private void dataGridViewDSTK_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow= e.RowIndex;
            txbNhanVien.Text = dataGridViewDSTK.Rows[numRow].Cells[1].Value.ToString();
            txbUserName.Text = dataGridViewDSTK.Rows[numRow].Cells[2].Value.ToString();
            txbPassWord.Text = dataGridViewDSTK.Rows[numRow].Cells[3].Value.ToString();
            txbCCCD.Text = dataGridViewDSTK.Rows[numRow].Cells[4].Value.ToString();
            txbSDT.Text = dataGridViewDSTK.Rows[numRow].Cells[5].Value.ToString();
            string chucVu=dataGridViewDSTK.Rows[numRow].Cells[6].Value.ToString();
            ckbVaiTro.Enabled = true;
            if (chucVu == "True")
                ckbVaiTro.Text = "Quản lí";
            else
                ckbVaiTro.Text = "Nhân viên";
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void defaultstate()
        {
            ckbVaiTro.Enabled=true;
            txbNhanVien.Text = "";
            txbUserName.Text = "";
            txbPassWord.Text = "";
            txbPassWord.Enabled = false;
            txbCCCD.Text = "";
            txbSDT.Text = "";
            ckbVaiTro.Text = "Quản lí";
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false; 
            btnLuu.Enabled = false;
            dataGridViewDSTK.Enabled=true;           
        }
        public void checkText()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            defaultstate();
            txbPassWord.Enabled=true;
            dataGridViewDSTK.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled=false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            defaultstate();
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (btnThem.Enabled == false)
            {
                if (txbNhanVien.Text=="") mess += "\nChưa nhập tên hiển thị.";
                if (taiKhoanTableAdapter.checkTenDangNhap(txbUserName.Text) > 0) mess += "\nTên đăng nhập đã tồn tại.";
                if (txbPassWord.Text.Length < 8) mess += "\nMật khẩu phải trên 8 kí tự.";
                if (txbCCCD.Text.Length<12) mess+="\nSố CCCD không hợp lệ." ;
                if (txbSDT.Text.Length <10) mess += "\nSDT không hợp lệ.";
                if (mess != "")
                    MessageBox.Show(mess, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    taiKhoanTableAdapter.InsertQuery(txbUserName.Text,
                                                 txbPassWord.Text,
                                                 txbNhanVien.Text,
                                                 txbSDT.Text,
                                                 txbCCCD.Text,
                                                 ckbVaiTro.Checked);
                    MessageBox.Show("Tài khoản đã được tạo");
                    defaultstate();
                }
            } 
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Xóa thành công");
                taiKhoanTableAdapter.DeleteQuery(txbUserName.Text, txbPassWord.Text);
                defaultstate();
            }                 
           
            
        }
    }
}