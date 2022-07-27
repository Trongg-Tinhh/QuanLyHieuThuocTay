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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
                /*MessageBox.Show("Bạn chưa -LƯU- thông tin chỉnh sửa ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);*/
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txbName.Enabled = true;
            txbPassWord.Enabled = true;
            txbNewPass.Enabled = true;
            txbNewPass2.Enabled = true;
            txbSDT.Enabled = true;
            txbCCCD.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txbName.Enabled =false;
            txbPassWord.Enabled = false;
            txbNewPass.Enabled = false;
            txbNewPass2.Enabled = false;
            txbCCCD.Enabled = false;
            txbSDT.Enabled = false;
            MessageBox.Show("Dữ liệu đã được lưu", "Thông báo");
        }

        private void frmAccoutProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLuu.Enabled == true)
            {
                var result = MessageBox.Show("Thông tin chỉnh sửa chưa được LƯU. Bạn muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    btnLuu_Click(sender, e);
                }
            }
        }
    }
}