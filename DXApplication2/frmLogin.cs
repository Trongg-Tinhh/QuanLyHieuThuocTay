using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static int? maTK;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Ket no database
            SqlConnection sqlCon = new SqlConnection(DataConnection.DataConnectionString.ConnectionString);
            try
            {
                sqlCon.Open();
                string User = txbUserName.Text;
                string Pass = txbPassWord.Text;
                String sql = "Select * from TaiKhoan where tenDangNhap = @tendangnhap and matKhau = @matkhau";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.Add(new SqlParameter("@tendangnhap", User));
                cmd.Parameters.Add(new SqlParameter("@matKhau", Pass));
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read() == true)
                {
                    maTK = taiKhoanTableAdapter.getMaTaiKhoan(User);
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();//uu tien thang ben tren
                    txbPassWord.Text = "";
                    txbUserName.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.TaiKhoan);

        }
    }
}
