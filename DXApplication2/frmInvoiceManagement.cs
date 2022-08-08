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
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.DanhSachHoaDon' table. You can move, or remove it, as needed.
            this.danhSachHoaDonTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachHoaDon);
        }

        private void FillEvent(object sender, EventArgs e)
        {
            string tenNV = txbTenNV.Text;
            string tenKH = txbTenKH.Text;
            string sdt = txbSDT.Text;

            danhSachHoaDonTableAdapter.FillByTenKH_SDT_TenNV(quanLyHieuThuocTayDataSet.DanhSachHoaDon, txbTenKH.Text.Trim(), sdt, tenNV);
            dataGridView1.DataSource = quanLyHieuThuocTayDataSet.DanhSachHoaDon;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}