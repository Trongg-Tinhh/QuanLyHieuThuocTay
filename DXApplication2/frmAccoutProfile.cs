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
    public partial class frmAccoutProfile : DevExpress.XtraEditors.XtraForm
    {
        public frmAccoutProfile()
        {
            InitializeComponent();
            defaultstate();
        }
        public void defaultstate()
        {
            string tenDN = frmLogin.tenDangNhap;
            string mk = frmLogin.matKhau;
            txbUserName.Text = tenDN;
            txbName.Text = taiKhoanTableAdapter.getTenNV(tenDN,mk);
            txbSDT.Text=taiKhoanTableAdapter.getSDT(tenDN,mk);
            txbCCCD.Text = taiKhoanTableAdapter.getCCCD(tenDN, mk);
            btnHuy.Text = "Thoát";
            txbName.ReadOnly = true;
            txbSDT.ReadOnly = true;
            txbCCCD.ReadOnly = true;
            btnLuu.Enabled = false;
            btnLuu.BackColor = SystemColors.ButtonFace;
            btnSua.Enabled = true;
            btnSua.BackColor= SystemColors.ActiveBorder;
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txbName.ReadOnly = false;
            txbSDT.ReadOnly = false;
            txbCCCD.ReadOnly=false;
            btnLuu.Enabled=true;
            btnLuu.BackColor=SystemColors.ActiveBorder;
            btnHuy.Text = "Hủy";
            btnSua.Enabled = false;
            btnSua.BackColor = SystemColors.ButtonFace;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenDN = frmLogin.tenDangNhap;
            string mk = frmLogin.matKhau;
            if (txbSDT.Text == null || txbSDT.Text.Length == 0)
            {
                errorProvider1.SetError(txbSDT, "Nhập số điện thoại");
                return;
            }
            if(txbCCCD.Text==null||txbCCCD.Text.Length == 0)
            {
                errorProvider1.SetError(txbCCCD, "Nhập số CCCD");
                return;
            }
            taiKhoanTableAdapter.Update_Ten_SDT_CCCD(txbName.Text, txbSDT.Text, txbCCCD.Text,mk,tenDN);
            MessageBox.Show("Thông tin đã cập nhật thành công");
            defaultstate();
        }

        private void frmAccoutProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnHuy.Text == "Hủy") defaultstate();
            else this.Close();
        }
    }
}