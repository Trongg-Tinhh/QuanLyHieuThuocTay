using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
            if (frmLogin.vaiTro == false)
            {
                tabTaiKhoan.Visible = false;
                tabSanPham.Visible = false;
                tabBangGia.Visible = false;                
            }
        }

        private void addForm(Form f)
        {
            fdfMain.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll=true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            fdfMain.Controls.Add(f);
            f.Show();
        }

        private void tabThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frmAccoutProfile frmAccoutProfile = new frmAccoutProfile();
            addForm(frmAccoutProfile);
        }

        private void tabBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frmBanHang = new frmBanHang();
            addForm(frmBanHang);
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tabDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            addForm(frmChangePassword);
        }

        private void tabTaiKhoan_Click(object sender, EventArgs e)
        {
            frmAccountManagement frmAccountManagement = new frmAccountManagement();
            addForm(frmAccountManagement);
        }

        private void tabSanPham_Click(object sender, EventArgs e)
        {
            frmProductManagement frmProductManagement = new frmProductManagement(); 
            addForm(frmProductManagement);
        }

        private void tabHoaDon_Click(object sender, EventArgs e)
        {
            frmInvoiceManagement frmInvoiceManagement = new frmInvoiceManagement();
            addForm(frmInvoiceManagement);
        }

        private void tabBangGia_Click(object sender, EventArgs e)
        {
            FrmBangGiaSanPham frmBangGia = new FrmBangGiaSanPham();
            addForm(frmBangGia);
        }
    }
}
