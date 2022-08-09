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
        private frmLogin loginInfo = new frmLogin();
        public frmBanHang()
        {
            InitializeComponent();
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
            txbCongDung.Text = null;
            txbDoTuoi.Text = null;
            numericSoLuong.Value = 0;
            btnThem.Enabled = false;
            btnXoaThuoc.Enabled = false;
        }

        // chức năng click vào 1 dòng ở dgv dữ liệu sẽ sổ lên trên textbox
        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
            btnXoaThuoc.Enabled = false;
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
            numericSoLuong.Maximum = soLuongToiDa; // quy định số lượng không được vượt quá số lượng tồn trong kho
        }

        // thêm sản phẩm vào bảng bên phải
        private void btnThem_Click(object sender, EventArgs e)
        {            
            string tenSP = txbTenSP.Text;
            string loaiSP = txbLoaiSP.Text;
            int soLuong = (int)numericSoLuong.Value;
            string maSP = danhSachSanPhamTableAdapter.GetMaByTen(tenSP);
            decimal? donGia = danhSachSanPhamTableAdapter.GetGiaByMa(maSP);

            if (soLuong == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK);
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


            // kiểm tra các ràng buộc
            if (tenKH == null || tenKH == "")
            {
                MessageBox.Show("Tên khách hàng không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(ngayBanStr == null || ngayBanStr == "")
            {
                MessageBox.Show("Ngày bán không được rỗng", "Thông báo", MessageBoxButtons.OK);
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
            }

            ClearData();
            listViewChiTietHoaDon.Items.Clear();
            txbTenKH.Text = null;
            txbSDT.Text = null;
            dateTimeEditNgayBan.Text = "";
        }

        private void listViewChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearData();
            btnXoaThuoc.Enabled = true;
        }

        private void txbTenKH_TextChanged(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}