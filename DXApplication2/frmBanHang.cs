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

        private void ToggleButton(Button b, bool enable)
        {
            b.Enabled = enable;

            if (enable)
                b.BackColor = SystemColors.ActiveBorder;
            else
                b.BackColor = SystemColors.ButtonFace;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.ChiTietHoaDon);
            // TODO: This line of code loads data into the 'quanLyHieuThuocTayDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.HoaDon);
            this.danhSachSanPhamTableAdapter.Fill(this.quanLyHieuThuocTayDataSet.DanhSachSanPham);
        }

        private void ClearData()
        {
            txbTenSP.Text = null;
            txbLoaiSP.Text = null;
            txbMaSP.Text = null;
            txbTenNSX.Text = null;
            numericSoLuong.Value = 0;
            ToggleButton(btnThem, false);
            ToggleButton(btnXoaThuoc, false);
        }

        // chức năng click vào 1 dòng ở dgv dữ liệu sẽ sổ lên trên textbox
        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ToggleButton(btnXoaThuoc, false);
            ToggleButton(btnThem, true);

            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            string maSP = dgvDanhSachSanPham.Rows[index].Cells[0].Value.ToString();
            string tenSP = dgvDanhSachSanPham.Rows[index].Cells[1].Value.ToString();
            string loaiSP = dgvDanhSachSanPham.Rows[index].Cells[2].Value.ToString();
            string tenNSX = dgvDanhSachSanPham.Rows[index].Cells[9].Value.ToString();
            int soLuongToiDa = (int)dgvDanhSachSanPham.Rows[index].Cells[6].Value;

            txbMaSP.Text = maSP;
            txbTenSP.Text = tenSP;
            txbLoaiSP.Text = loaiSP;
            txbTenNSX.Text = tenNSX;
            numericSoLuong.Value = 0;
            numericSoLuong.Maximum = soLuongToiDa; // quy định số lượng không được vượt quá số lượng tồn trong kho
        }

        // thêm sản phẩm vào bảng bên phải
        private void btnThem_Click(object sender, EventArgs e)
        {            
            errorProvider1.Clear();
            string tenSP = txbTenSP.Text;
            string loaiSP = txbLoaiSP.Text;
            int soLuong = (int)numericSoLuong.Value;
            string maSP = txbMaSP.Text;
            decimal? donGia = decimal.Parse(danhSachSanPhamTableAdapter.GetGiaByMa(maSP).ToString());

            if (soLuong == 0)
            {
                errorProvider1.SetError(numericSoLuong, "Số lượng phải lớn hơn 0");
                return;
            }

            string[] row =
            {
                maSP, tenSP, loaiSP, soLuong.ToString(), donGia.ToString(),
            };

            // mỗi lần thêm sẽ kiểm tra xem thông tin có trùng lặp hay không
            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
            {
                string maItem = item.SubItems[0].Text.ToString();

                // nếu trùng thì hỏi người dùng có muốn ghi đè hay không
                // nếu ghi đè thì chỉ ghi đè số lượng
                if (maItem == maSP)
                {
                    DialogResult result = MessageBox.Show("Thêm trùng sản phẩm. Ghi đè lên sản phẩm hiện có?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        item.SubItems[3].Text = soLuong.ToString();
                        ClearData();
                    }
                        
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(row);
            listViewChiTietHoaDon.Items.Add(newItem);
            ClearData();

            decimal? total = 0;
            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
            {
                int sl = int.Parse(item.SubItems[3].Text.ToString());
                decimal? dg = decimal.Parse(item.SubItems[4].Text);

                total += sl * dg;
            }
            lblThanhTien.Text = total.ToString();
        }

        // chức năng lọc sản phẩm
        
        private void FillEvent(object sender, EventArgs e)
        {
            string tenSP = txbTenSP.Text;
            string loaiSP = txbLoaiSP.Text;
            string nhaSanXuat = txbTenNSX.Text;

            danhSachSanPhamTableAdapter.FillByTenSPAndCongDungAndNSX(quanLyHieuThuocTayDataSet.DanhSachSanPham, tenSP, loaiSP, nhaSanXuat);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {            
            ClearData();
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
                if (item.Selected)
                    listViewChiTietHoaDon.Items.Remove(item);
            ClearData();
        }

        // chức năng thanh toán. Khi nhấn thanh toán sẽ lấy hết dữ liệu từ các textbox và listview để tiến hành tính tiền.
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // lấy thông tin hóa đơn để lưu vào db.
            string tenKH = txbTenKH.Text;
            string sdt = txbSDT.Text;
            int? maTK = frmLogin.maTK;
            DateTime ngayBan;
            string ngayBanStr = dateTimeEditNgayBan.Text;

            errorProvider1.Clear();
            // kiểm tra các ràng buộc
            if (tenKH == null || tenKH == "")
            {
                errorProvider1.SetError(txbTenKH,"Tên khách hàng không được rỗng");
                return;
            }
            if (sdt.Length != 10 && sdt!="")
            {
                errorProvider1.SetError(txbSDT,"Số điện thoại không hợp lệ");
                return;
            }
            if(ngayBanStr == null || ngayBanStr == "")
            {
                errorProvider1.SetError(dateTimeEditNgayBan, "Ngày bán không được rỗng");
                return;
            }

            if (listViewChiTietHoaDon.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sản phẩm không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ngayBan = DateTime.Parse(ngayBanStr);

            // lấy hết dữ liệu từ listview để tính tiền và lưu vào db
            decimal total = decimal.Parse(lblThanhTien.Text.ToString());
            hoaDonTableAdapter.Insert(tenKH, ngayBan, sdt, maTK, total);
            int maHD = int.Parse(hoaDonTableAdapter.GetMaByOtherFields(tenKH, ngayBan, sdt, maTK, total).ToString());
            foreach (ListViewItem item in listViewChiTietHoaDon.Items)
            {
                string maSP = item.SubItems[0].Text.ToString();
                string tenSP = item.SubItems[1].Text.ToString();
                string loaiSP = item.SubItems[2].Text.ToString();
                int soLuong = int.Parse(item.SubItems[3].Text.ToString());
                decimal? donGia = decimal.Parse(item.SubItems[4].Text);

                chiTietHoaDonTableAdapter.Insert(maHD, maSP, soLuong, (decimal)donGia);
                danhSachSanPhamTableAdapter.UpdateSoLuong(soLuong, maSP);
            }

            ClearData();
            listViewChiTietHoaDon.Items.Clear();
            danhSachSanPhamTableAdapter.Fill(quanLyHieuThuocTayDataSet.DanhSachSanPham);
            txbTenKH.Text = null;
            txbSDT.Text = null;
            dateTimeEditNgayBan.Text = null;
        }

        private void listViewChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearData();
            ToggleButton(btnXoaThuoc, true);
        }

        private void txbTenKH_TextChanged(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txbSDT_EditValueChanged(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}