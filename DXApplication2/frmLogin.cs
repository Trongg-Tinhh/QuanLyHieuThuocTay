using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();//uu tien thang ben tren
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void chbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMatKhau.Checked==true)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else txbPassWord.UseSystemPasswordChar = true;
        }
    }
}
