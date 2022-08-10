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
            btnSua.BackColor = SystemColors.ActiveBorder;
            btnXoa.Enabled = true;
            btnXoa.BackColor = SystemColors.ActiveBorder;
            btnHuy.Enabled = true;
            btnHuy.BackColor = SystemColors.ActiveBorder;
        }
        public void defaultstate()
        {
            //dataGridViewDSTK.BackgroundColor =;
            errorProvider1.Clear();
            txbPassWord.Properties.UseSystemPasswordChar = true;
            ckbVaiTro.Enabled=true;
            txbNhanVien.Text = "";
            txbUserName.Text = "";
            txbPassWord.Text = "";
            txbPassWord.Enabled = false;
            txbCCCD.Text = "";
            txbSDT.Text = "";
            ckbVaiTro.Text = "Quản lí";
            btnThem.Enabled = true;
            btnThem.BackColor = SystemColors.ActiveBorder;
            btnXoa.Enabled = false;
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnSua.Enabled = false;
            btnSua.BackColor = SystemColors.ButtonFace;
            btnHuy.Enabled = false; 
            btnHuy.BackColor = SystemColors.ButtonFace;
            btnLuu.Enabled = false;
            btnLuu.BackColor = SystemColors.ButtonFace;
            dataGridViewDSTK.Enabled=true;
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            defaultstate();
            txbUserName.Enabled = true;
            txbPassWord.Enabled=true;
            txbPassWord.Properties.UseSystemPasswordChar = false;
            dataGridViewDSTK.Enabled = false;
            btnLuu.Enabled = true;
            btnLuu.BackColor = SystemColors.ActiveBorder;
            btnHuy.Enabled = true;
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnThem.Enabled=false;
            btnThem.BackColor = SystemColors.ButtonFace;
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
            //them du lieu
            if (btnThem.Enabled == false&& txbUserName.Enabled==true && txbPassWord.Enabled==true)
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
            else
            {
                // sua du lieu
                if (btnSua.Enabled == false && txbUserName.Enabled==false &&txbPassWord.Enabled==false) 
                {
                    if (txbNhanVien.Text == "")
                    {
                        errorProvider1.SetError(txbNhanVien, "Chưa nhập tên hiển thị.");
                        flag = false;
                    }
                    if (txbCCCD.Text.Length != 12)
                    {
                        errorProvider1.SetError(txbCCCD, "Số CCCD không hợp lệ (12 số).");
                        flag = false;
                    }
                    if (txbSDT.Text.Length != 10)
                    {
                        errorProvider1.SetError(txbSDT, "SDT không hợp lệ.");
                        flag = false;
                    }
                    if (flag == true)
                    {
                        taiKhoanTableAdapter.Update_TaiKhoanFull(
                                                            txbNhanVien.Text,
                                                            txbSDT.Text,
                                                            txbCCCD.Text,
                                                            ckbVaiTro.Checked,
                                                            txbUserName.Text,
                                                            txbPassWord.Text);
                        MessageBox.Show("Tài khoản đã được sửa thông tin");
                        defaultstate();
                    }

                }
            }
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenDN=txbUserName.Text;
            string passW=txbPassWord.Text;
            int matk = int.Parse(taiKhoanTableAdapter.getMaTaiKhoan(tenDN).ToString());
            int soHoaDonBan=int.Parse(taiKhoanTableAdapter.Count_HD(matk).ToString());
            if (tenDN == frmLogin.tenDangNhap)
            {
                MessageBox.Show("Tài khoản đang được sử dụng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (soHoaDonBan > 0)
            {
                MessageBox.Show("Tài khoản này không được xóa ", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Xóa thành công");
                taiKhoanTableAdapter.DeleteQuery(tenDN, passW);
                defaultstate();
            }                 
           
            
        }

        private void FillEvent(object sender, EventArgs e)
        {
            string tenHT = txbNhanVien.Text;
            string tenDN = txbUserName.Text;
            bool vaiTro = ckbVaiTro.Checked;
            btnHuy.Enabled=true;
            btnHuy.BackColor = SystemColors.ActiveBorder;
            this.taiKhoanTableAdapter.FillByTenHienThi_TenDangNhap_VaiTro(quanLyHieuThuocTayDataSet.TaiKhoan, tenHT, tenDN, vaiTro);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled=false;
            btnSua.BackColor = SystemColors.ButtonFace;
            btnXoa.Enabled=false;
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnLuu.Enabled=true;
            btnLuu.BackColor = SystemColors.ActiveBorder;
            btnThem.Enabled=false;
            btnThem.BackColor = SystemColors.ButtonFace;    
            dataGridViewDSTK.Enabled=false;
            txbUserName.Enabled=false;
            txbPassWord.Enabled=false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}