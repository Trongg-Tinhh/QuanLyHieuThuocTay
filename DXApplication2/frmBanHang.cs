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
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            this.danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
        }

        private void ClearData()
        {
            txbTenSP.Text = null;
            txbLoaiSP.Text = null;
            txbCongDung.Text = null;
            txbDoTuoi.Text = null;
            numericSoLuong.Value = 0;
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            string tenSP = dgvDanhSachSanPham.Rows[index].Cells[1].Value.ToString();
            string loaiSP = dgvDanhSachSanPham.Rows[index].Cells[2].Value.ToString();
            string congDung = dgvDanhSachSanPham.Rows[index].Cells[3].Value.ToString();
            string doTuoi = dgvDanhSachSanPham.Rows[index].Cells[5].Value.ToString();
            int soLuongToiDa = (int)dgvDanhSachSanPham.Rows[index].Cells[6].Value;

            txbTenSP.Text = tenSP;
            txbLoaiSP.Text = loaiSP;
            txbCongDung.Text = congDung;
            txbDoTuoi.Text = doTuoi;
            numericSoLuong.Value = 0;
            numericSoLuong.Maximum = soLuongToiDa;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSP = txbTenSP.Text;
            string loaiSP = txbLoaiSP.Text;
            int soLuong = (int)numericSoLuong.Value;
            string maSP = danhSachSanPhamTableAdapter.GetMaByTen(tenSP);
            decimal? donGia = danhSachSanPhamTableAdapter.GetGiaByMa(maSP);

            if(soLuong == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string[] row =
            {
                maSP, tenSP, loaiSP, soLuong.ToString(), donGia.ToString(),
            };

            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
            {
                string maItem = item.SubItems[0].Text.ToString();
                string temItem = item.SubItems[1].Text.ToString();
                string loaiItem = item.SubItems[2].Text.ToString();
                int soLuongItem = int.Parse(item.SubItems[3].Text.ToString());
                decimal? donGiaItem = decimal.Parse(item.SubItems[4].Text);

                if (maItem == maSP)
                {
                    DialogResult result = MessageBox.Show("Thêm trùng sản phẩm. Ghi đè lên sản phẩm hiện có?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        item.SubItems[3].Text = soLuong.ToString();
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(row);
            listViewChiTietHoaDon.Items.Add(newItem);
            ClearData();
        }

        private void FillEvent(object sender, EventArgs e)
        {
            string tenSP = txbTenSP.Text;
            string loaiSP = txbLoaiSP.Text;
            string congDung = txbCongDung.Text;
            string doTuoi = txbDoTuoi.Text;

            danhSachSanPhamTableAdapter.FillByTen_Loai_CongDung_DoTuoi(quanLyHieuThuocTayDataSet.DanhSachSanPham, tenSP, loaiSP, congDung, doTuoi);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            ClearData(); 
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
                if(item.Selected)
                    listViewChiTietHoaDon.Items.Remove(item);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string tenKH = txbTenKH.Text;
            string sdt = txbSDT.Text;
            DateTime ngayBan;
            string ngayBanStr = dateTimeEditNgayBan.Text;
            if(ngayBanStr == null || ngayBanStr == "") 
                ngayBan = DateTime.Now;
            else
                ngayBan = DateTime.Parse(ngayBanStr);

            if (tenKH == null || tenKH == "")
            {
                MessageBox.Show("Tên khách hàng không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (sdt == null || sdt == "")
            {
                MessageBox.Show("Số điện thoại không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (listViewChiTietHoaDon.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sản phẩm không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            decimal? total = 0;
            foreach(ListViewItem item in listViewChiTietHoaDon.Items)
            {
                string maSP = item.SubItems[0].Text.ToString();
                string tenSP = item.SubItems[1].Text.ToString();
                string loaiSP = item.SubItems[2].Text.ToString();
                int soLuong = int.Parse(item.SubItems[3].Text.ToString());
                decimal? donGia = decimal.Parse(item.SubItems[4].Text);

                total += donGia*soLuong;

                MessageBox.Show(string.Format("{0} {1} {2} {3}", maSP, tenSP, loaiSP, soLuong));
            }
            lblThanhTien.Text = "Tổng tiền: " + total.ToString() + "VND";
        }
    }
}