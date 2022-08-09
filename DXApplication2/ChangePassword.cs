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
            if (txbPassword.Text != frmLogin.matKhau)
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
               

        }

        private void chbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !ckbMatKhau.Checked;

        }

        private void cbkMatKhauNew2_CheckedChanged(object sender, EventArgs e)
        {
            txbPasswordNew.UseSystemPasswordChar = !ckbMatKhauNew.Checked;
            txbPasswordNew2.UseSystemPasswordChar = !ckbMatKhauNew.Checked;   
        }
    }
}