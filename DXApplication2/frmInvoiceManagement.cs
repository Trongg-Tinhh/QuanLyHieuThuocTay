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
    public partial class frmInvoiceManagement : DevExpress.XtraEditors.XtraForm
    {
        public frmInvoiceManagement()
        {
            InitializeComponent();
        }

        private void frmInvoiceManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet1.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.quanLyHieuThuocTayDataSet1.ChiTietHoaDon);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyHieuThuocTayDataSet1.HoaDon);

        }
    }
}