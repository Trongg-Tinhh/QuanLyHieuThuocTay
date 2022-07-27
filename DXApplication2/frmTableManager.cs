using System;

namespace DXApplication2
{
    public partial class frmTableManager : DevExpress.XtraEditors.XtraForm
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccoutProfile f = new frmAccoutProfile();
            f.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.ShowDialog();
        }
    }
}