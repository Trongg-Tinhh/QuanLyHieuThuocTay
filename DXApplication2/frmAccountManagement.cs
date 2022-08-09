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
            if (e.RowIndex < 0) return;
            int numRow = e.RowIndex;

            string tenNV = dataGridViewDSTK.Rows[numRow].Cells[1].Value.ToString();
            string username = dataGridViewDSTK.Rows[numRow].Cells[2].Value.ToString();
            string password = dataGridViewDSTK.Rows[numRow].Cells[3].Value.ToString();
            string cccd = dataGridViewDSTK.Rows[numRow].Cells[4].Value.ToString();
            string sdt = dataGridViewDSTK.Rows[numRow].Cells[5].Value.ToString();
            string chucVu = dataGridViewDSTK.Rows[numRow].Cells[6].Value.ToString();

            txbNhanVien.Text = tenNV;
            txbUserName.Text = username;
            txbPassWord.Text = password;
            txbCCCD.Text = cccd;
            txbSDT.Text = sdt;

            ckbVaiTro.Enabled = true;
            if (chucVu == "True")
                ckbVaiTro.Checked = true;
            else
                ckbVaiTro.Checked = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void defaultstate()
        {
            errorProvider1.Clear();
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
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
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
            if(btnThem.Enabled==false)
                if(MessageBox.Show("Bạn muốn hủy tiến trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    defaultstate();
                    return;
                }
            defaultstate();
            
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (btnThem.Enabled == false)
            {
                if (txbUserName.Text == "")
                {
                    errorProvider1.SetError(txbUserName, "Nhập tên đăng nhập.");
                    flag = false;
                }
                if (txbNhanVien.Text == "") {
                    errorProvider1.SetError(txbNhanVien,"Chưa nhập tên hiển thị.");
                    flag = false;
                }
                if (taiKhoanTableAdapter.checkTenDangNhap(txbUserName.Text) > 0){
                    errorProvider1.SetError(txbUserName, "Tên đăng nhập đã tồn tại.");
                    flag = false;
                } 
                if (txbPassWord.Text.Length < 8)
                {
                    errorProvider1.SetError(txbPassWord, "Mật khẩu yếu (trên 8 kí tự).");
                    flag = false;
                }
                if (txbCCCD.Text.Length!=12)
                {
                    errorProvider1.SetError(txbCCCD, "Số CCCD không hợp lệ (12 số).");
                    flag = false;
                }
                if (txbSDT.Text.Length !=10)
                {
                    errorProvider1.SetError(txbSDT, "SDT không hợp lệ.");
                    flag = false;
                }
                if (flag==true)
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

        private void FillEvent(object sender, EventArgs e)
        {
            string tenHT = txbNhanVien.Text;
            string tenDN = txbUserName.Text;
            bool vaiTro = ckbVaiTro.Checked;
            btnHuy.Enabled=true;
            this.taiKhoanTableAdapter.FillByTenHienThi_TenDangNhap_VaiTro(quanLyHieuThuocTayDataSet.TaiKhoan, tenHT, tenDN, vaiTro);
        }
    }
}