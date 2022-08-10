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
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
            txbUserName.Text = frmLogin.tenDangNhap;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool flag = true;
            if (txbPassword.Text == "")
            {
                errorProvider1.SetError(txbPassword, "Nhập mật khẩu");
                flag = false;
            }
            else
            if (txbPassword.Text.Equals( frmLogin.matKhau)== false)
            {
                errorProvider1.SetError(txbPassword,"Mật khẩu không đúng");
                flag = false;
            }
            
            if (txbPasswordNew.Text.Length < 8)
            {
                errorProvider1.SetError(txbPasswordNew, "Nhập mật khẩu mới! Mật khẩu phải trên 8 kí tự");
                flag = false;
            }
            if (txbPasswordNew2.Text != txbPasswordNew.Text)
            {
                errorProvider1.SetError(txbPasswordNew2, "Mật khẩu nhập lại không khớp");
                flag = false;
            }
            if (flag == true)
            {
                string passNew=txbPasswordNew.Text;
                string tenDN = frmLogin.tenDangNhap;
                string mk = frmLogin.matKhau;
                taiKhoanTableAdapter.Update_Password(passNew, mk, tenDN);
                this.taiKhoanTableAdapter.Fill(quanLyHieuThuocTayDataSet.TaiKhoan);
                frmLogin.matKhau= passNew;           
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }   


        }

        private void chbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !ckbMatKhau.Checked;

        }

        private void cbkMatKhauNew2_CheckedChanged(object sender, EventArgs e)
        {
            txbPasswordNew.Properties.UseSystemPasswordChar = !ckbMatKhauNew.Checked;
            txbPasswordNew2.UseSystemPasswordChar = !ckbMatKhauNew.Checked;   
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);

        }

        
    }
}