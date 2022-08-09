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

            if (tenNV == null)
                tenNV = "";
            if (tenKH == null)
                tenKH = "";
            if (sdt == null)
                sdt = "";


            danhSachHoaDonTableAdapter.FillByTenKH_TenNV(quanLyHieuThuocTayDataSet.DanhSachHoaDon, tenKH, tenNV);
        }

        

                
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbMaHD.Text = "";
            txbTenKH.Text = "";
            txbSDT.Text = "";
            dateTimeNgayBan.Text = "";
            txbThanhTien.Text = "";
            txbTenNV.Text = "";
            this.dSChiTietHoaDonTableAdapter.Fill(quanLyHieuThuocTayDataSet.DSChiTietHoaDon,0);
        }

        private void dataGridViewDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow < 0) return;
            string mahdStr = dataGridViewDSHD.Rows[numrow].Cells[0].Value.ToString();
            string tenkhach = dataGridViewDSHD.Rows[numrow].Cells[1].Value.ToString();
            string sdt = dataGridViewDSHD.Rows[numrow].Cells[2].Value.ToString();
            string ngayban = dataGridViewDSHD.Rows[numrow].Cells[3].Value.ToString();
            string thanhtien = dataGridViewDSHD.Rows[numrow].Cells[4].Value.ToString();
            string tennv = dataGridViewDSHD.Rows[numrow].Cells[5].Value.ToString();
            txbMaHD.Text = mahdStr;
            txbTenKH.Text = tenkhach;
            txbSDT.Text = sdt;
            dateTimeNgayBan.Text = ngayban;
            txbThanhTien.Text = thanhtien + " VND";
            txbTenNV.Text = tennv;

            int mahd=int.Parse(mahdStr);
            dSChiTietHoaDonTableAdapter.Fill(quanLyHieuThuocTayDataSet.DSChiTietHoaDon, mahd);
        }
    }
}