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
using System.Text.RegularExpressions;

namespace DXApplication2
{
    public partial class frmAccountManagement : DevExpress.XtraEditors.XtraForm
    {
        private bool isAdd = true; // true: add | false: edit
        public frmAccountManagement()
        {
            InitializeComponent();
            DefaultState();
        }
        
        private void ToggleButton(Button b, bool enable)
        {
            b.Enabled = enable;
            if (enable)
                b.BackColor = SystemColors.ActiveBorder;
            else
                b.BackColor = SystemColors.ButtonFace;
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
            txbPassWord.Enabled = false;
        }

        private void dataGridViewDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;

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
            ToggleButton(btnSua, true);
            ToggleButton(btnXoa, true);
            ToggleButton(btnHuy, true);
        }
        
        private void ClearData()
        {
            errorProvider.Clear();
            txbPassWord.Properties.UseSystemPasswordChar = true;
            ckbVaiTro.Enabled=true;
            txbNhanVien.Text = "";
            txbUserName.Text = "";
            txbPassWord.Text = "";
            txbPassWord.ReadOnly = true;
            txbCCCD.Text = "";
            txbSDT.Text = "";
        }

        private void DefaultState()
        {
            ToggleButton(btnThem, true);
            ToggleButton(btnXoa, false);
            ToggleButton(btnHuy, false);
            ToggleButton(btnSua, false);
            ToggleButton(btnLuu, false);

            dataGridViewDSTK.Enabled = true;

            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ClearData();
            DefaultState();
            txbPassWord.ReadOnly = false;
            txbPassWord.Enabled = true;
            txbPassWord.Properties.UseSystemPasswordChar = false;
            dataGridViewDSTK.Enabled = false;
            ToggleButton(btnThem, false);
            ToggleButton(btnHuy, true);
            ToggleButton(btnLuu, true);
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearData();
            if(btnThem.Enabled==false)
                if(MessageBox.Show("Bạn muốn hủy tiến trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    DefaultState();
                    return;
                }
            DefaultState();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Regex usernameRegex = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
            bool hasError = false;

            //them du lieu
            if (isAdd == true)
            {
                if (txbUserName.Text == "")
                {
                    errorProvider.SetError(txbUserName, "Nhập tên đăng nhập.");
                    hasError = true;
                }
                if (!usernameRegex.IsMatch(txbUserName.Text))
                {
                    errorProvider.SetError(txbUserName, "Tên đăng nhập không hơp lệ.");
                    hasError = true;
                }
                if (txbNhanVien.Text == "") {
                    errorProvider.SetError(txbNhanVien,"Chưa nhập tên hiển thị.");
                    hasError = true;
                }
                if (taiKhoanTableAdapter.checkTenDangNhap(txbUserName.Text) > 0){
                    errorProvider.SetError(txbUserName, "Tên đăng nhập đã tồn tại.");
                    hasError = true;
                } 
                if (txbPassWord.Text.Length < 8)
                {
                    errorProvider.SetError(txbPassWord, "Mật khẩu yếu (trên 8 kí tự).");
                    hasError = true;
                }
                if (txbCCCD.Text.Length!=12)
                {
                    errorProvider.SetError(txbCCCD, "Số CCCD không hợp lệ (12 số).");
                    hasError = true;
                }
                if (txbSDT.Text.Length !=10)
                {
                    errorProvider.SetError(txbSDT, "SDT không hợp lệ.");
                    hasError = true;
                }
                if (!hasError)
                {
                    taiKhoanTableAdapter.InsertQuery(txbUserName.Text,
                                                 txbPassWord.Text,
                                                 txbNhanVien.Text,
                                                 txbSDT.Text,
                                                 txbCCCD.Text,
                                                 ckbVaiTro.Checked);
                    MessageBox.Show("Tài khoản đã được tạo");
                    DefaultState();
                    ClearData();
                }
            }
            else
            {
                // sua du lieu
                if (isAdd == false)
                {
                    if (txbNhanVien.Text == "")
                    {
                        errorProvider.SetError(txbNhanVien, "Chưa nhập tên hiển thị.");
                        hasError = true;
                    }
                    if (txbCCCD.Text.Length != 12)
                    {
                        errorProvider.SetError(txbCCCD, "Số CCCD không hợp lệ (12 số).");
                        hasError = true;
                    }
                    if (txbSDT.Text.Length != 10)
                    {
                        errorProvider.SetError(txbSDT, "SDT không hợp lệ.");
                        hasError = true;
                    }
                    if (!hasError)
                    {
                        taiKhoanTableAdapter.Update_TaiKhoanFull(
                                                            txbNhanVien.Text,
                                                            txbSDT.Text,
                                                            txbCCCD.Text,
                                                            ckbVaiTro.Checked,
                                                            txbUserName.Text,
                                                            txbPassWord.Text);
                        MessageBox.Show("Tài khoản đã được sửa thông tin");
                        DefaultState();
                        ClearData();
                    }

                }
            }
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenDN = txbUserName.Text;
            string passW = txbPassWord.Text;
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
                ClearData();
                DefaultState();
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
            isAdd = false;

            ToggleButton(btnSua, false);
            ToggleButton(btnXoa, false);
            ToggleButton(btnThem, false);
            ToggleButton(btnLuu, true);

            dataGridViewDSTK.Enabled=false;
            txbUserName.Enabled=false;
            txbPassWord.Enabled=false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void preventChar(object sender, KeyPressEventArgs e)
        {
            string notAllowedChars = "\" / - \\ [ ] : ; | = , + * ? < >";
            if (notAllowedChars.Contains(e.KeyChar))
                e.Handled = true;
        }
    }
}