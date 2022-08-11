namespace DXApplication2
{
    partial class frmInvoiceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dataGridViewDSCTHD = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHieuThuocTayDataSet = new DXApplication2.QuanLyHieuThuocTayDataSet();
            this.label23 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.dataGridViewDSHD = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimeNgayBan = new DevExpress.XtraEditors.DateEdit();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txbTenKH = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txbThanhTien = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txbSDT = new DevExpress.XtraEditors.TextEdit();
            this.label20 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txbTenNV = new DevExpress.XtraEditors.TextEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.danhSachHoaDonTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.DanhSachHoaDonTableAdapter();
            this.dSChiTietHoaDonTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.DSChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeNgayBan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeNgayBan.Properties)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).BeginInit();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel5
            // 
            this.tablePanel5.AutoScroll = true;
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel5.Controls.Add(this.btnHuy);
            this.tablePanel5.Controls.Add(this.label1);
            this.tablePanel5.Controls.Add(this.tableLayoutPanel2);
            this.tablePanel5.Controls.Add(this.tablePanel6);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(0, 0);
            this.tablePanel5.MinimumSize = new System.Drawing.Size(958, 500);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F)});
            this.tablePanel5.Size = new System.Drawing.Size(958, 500);
            this.tablePanel5.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tablePanel5.SetColumn(this.btnHuy, 1);
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(818, 60);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHuy.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnHuy.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnHuy.Name = "btnHuy";
            this.tablePanel5.SetRow(this.btnHuy, 1);
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel5.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel5.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(808, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tablePanel5.SetColumn(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tablePanel5.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.72269F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.27731F));
            this.tableLayoutPanel2.Controls.Add(this.panel23, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel22, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tablePanel5.SetRow(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(952, 357);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.dataGridViewDSCTHD);
            this.panel23.Controls.Add(this.label23);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(543, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(406, 351);
            this.panel23.TabIndex = 3;
            // 
            // dataGridViewDSCTHD
            // 
            this.dataGridViewDSCTHD.AllowUserToAddRows = false;
            this.dataGridViewDSCTHD.AllowUserToDeleteRows = false;
            this.dataGridViewDSCTHD.AutoGenerateColumns = false;
            this.dataGridViewDSCTHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDSCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn1});
            this.dataGridViewDSCTHD.DataSource = this.dSChiTietHoaDonBindingSource;
            this.dataGridViewDSCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSCTHD.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewDSCTHD.Name = "dataGridViewDSCTHD";
            this.dataGridViewDSCTHD.ReadOnly = true;
            this.dataGridViewDSCTHD.RowHeadersWidth = 51;
            this.dataGridViewDSCTHD.Size = new System.Drawing.Size(406, 327);
            this.dataGridViewDSCTHD.TabIndex = 11;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "maSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSPDataGridViewTextBoxColumn.Width = 250;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 80;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "donGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.donGiaDataGridViewTextBoxColumn.Width = 80;
            // 
            // thanhTienDataGridViewTextBoxColumn1
            // 
            this.thanhTienDataGridViewTextBoxColumn1.DataPropertyName = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn1.HeaderText = "Tổng tiền";
            this.thanhTienDataGridViewTextBoxColumn1.MinimumWidth = 125;
            this.thanhTienDataGridViewTextBoxColumn1.Name = "thanhTienDataGridViewTextBoxColumn1";
            this.thanhTienDataGridViewTextBoxColumn1.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dSChiTietHoaDonBindingSource
            // 
            this.dSChiTietHoaDonBindingSource.DataMember = "DSChiTietHoaDon";
            this.dSChiTietHoaDonBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // quanLyHieuThuocTayDataSet
            // 
            this.quanLyHieuThuocTayDataSet.DataSetName = "QuanLyHieuThuocTayDataSet";
            this.quanLyHieuThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(265, 24);
            this.label23.TabIndex = 10;
            this.label23.Text = "                Chi tiết hóa đơn";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.dataGridViewDSHD);
            this.panel22.Controls.Add(this.label22);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(534, 351);
            this.panel22.TabIndex = 2;
            // 
            // dataGridViewDSHD
            // 
            this.dataGridViewDSHD.AllowUserToAddRows = false;
            this.dataGridViewDSHD.AllowUserToDeleteRows = false;
            this.dataGridViewDSHD.AutoGenerateColumns = false;
            this.dataGridViewDSHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.tenKhachDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn});
            this.dataGridViewDSHD.DataSource = this.danhSachHoaDonBindingSource;
            this.dataGridViewDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSHD.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewDSHD.Name = "dataGridViewDSHD";
            this.dataGridViewDSHD.ReadOnly = true;
            this.dataGridViewDSHD.RowHeadersWidth = 51;
            this.dataGridViewDSHD.RowTemplate.Height = 24;
            this.dataGridViewDSHD.Size = new System.Drawing.Size(534, 327);
            this.dataGridViewDSHD.TabIndex = 11;
            this.dataGridViewDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHD_CellClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "maHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHDDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenKhachDataGridViewTextBoxColumn
            // 
            this.tenKhachDataGridViewTextBoxColumn.DataPropertyName = "tenKhach";
            this.tenKhachDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKhachDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.tenKhachDataGridViewTextBoxColumn.Name = "tenKhachDataGridViewTextBoxColumn";
            this.tenKhachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhachDataGridViewTextBoxColumn.Width = 200;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "ngayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "Ngày bán";
            this.ngayBanDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            this.ngayBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "tenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Nhân viên bán";
            this.tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhanVienDataGridViewTextBoxColumn.Width = 200;
            // 
            // danhSachHoaDonBindingSource
            // 
            this.danhSachHoaDonBindingSource.DataMember = "DanhSachHoaDon";
            this.danhSachHoaDonBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(292, 24);
            this.label22.TabIndex = 10;
            this.label22.Text = "               Danh sách hóa đơn";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablePanel6
            // 
            this.tablePanel6.AutoScroll = true;
            this.tablePanel5.SetColumn(this.tablePanel6, 0);
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel6.Controls.Add(this.panel16);
            this.tablePanel6.Controls.Add(this.panel17);
            this.tablePanel6.Controls.Add(this.panel18);
            this.tablePanel6.Controls.Add(this.panel19);
            this.tablePanel6.Controls.Add(this.panel20);
            this.tablePanel6.Controls.Add(this.panel21);
            this.tablePanel6.Location = new System.Drawing.Point(3, 27);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel5.SetRow(this.tablePanel6, 1);
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel6.Size = new System.Drawing.Size(808, 106);
            this.tablePanel6.TabIndex = 8;
            // 
            // panel16
            // 
            this.tablePanel6.SetColumn(this.panel16, 0);
            this.panel16.Controls.Add(this.txbMaHD);
            this.panel16.Controls.Add(this.label16);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel16.Location = new System.Drawing.Point(4, 2);
            this.panel16.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel16.Name = "panel16";
            this.tablePanel6.SetRow(this.panel16, 0);
            this.panel16.Size = new System.Drawing.Size(261, 49);
            this.panel16.TabIndex = 0;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbMaHD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHD.Location = new System.Drawing.Point(0, 21);
            this.txbMaHD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(261, 28);
            this.txbMaHD.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã hóa đơn:";
            // 
            // panel17
            // 
            this.tablePanel6.SetColumn(this.panel17, 0);
            this.panel17.Controls.Add(this.label17);
            this.panel17.Controls.Add(this.dateTimeNgayBan);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel17.Location = new System.Drawing.Point(4, 55);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel17.Name = "panel17";
            this.tablePanel6.SetRow(this.panel17, 1);
            this.panel17.Size = new System.Drawing.Size(261, 49);
            this.panel17.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Ngày bán:";
            // 
            // dateTimeNgayBan
            // 
            this.dateTimeNgayBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimeNgayBan.EditValue = null;
            this.dateTimeNgayBan.Location = new System.Drawing.Point(0, 21);
            this.dateTimeNgayBan.Name = "dateTimeNgayBan";
            this.dateTimeNgayBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayBan.Properties.Appearance.Options.UseFont = true;
            this.dateTimeNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeNgayBan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeNgayBan.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateTimeNgayBan.Properties.DisplayFormat.FormatString = "";
            this.dateTimeNgayBan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimeNgayBan.Properties.EditFormat.FormatString = "";
            this.dateTimeNgayBan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateTimeNgayBan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.dateTimeNgayBan.Properties.MaskSettings.Set("mask", "d");
            this.dateTimeNgayBan.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateTimeNgayBan.Size = new System.Drawing.Size(261, 28);
            this.dateTimeNgayBan.TabIndex = 1;
            // 
            // panel18
            // 
            this.tablePanel6.SetColumn(this.panel18, 1);
            this.panel18.Controls.Add(this.txbTenKH);
            this.panel18.Controls.Add(this.label18);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel18.Location = new System.Drawing.Point(273, 2);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel18.Name = "panel18";
            this.tablePanel6.SetRow(this.panel18, 0);
            this.panel18.Size = new System.Drawing.Size(261, 49);
            this.panel18.TabIndex = 1;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbTenKH.Location = new System.Drawing.Point(0, 21);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenKH.Properties.Appearance.Options.UseFont = true;
            this.txbTenKH.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txbTenKH.Properties.MaskSettings.Set("mask", "([a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA-Z]+)(" +
        "(\\s{1}[a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA" +
        "-Z]+){1,})");
            this.txbTenKH.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txbTenKH.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbTenKH.Size = new System.Drawing.Size(261, 28);
            this.txbTenKH.TabIndex = 9;
            this.txbTenKH.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên khách:";
            // 
            // panel19
            // 
            this.tablePanel6.SetColumn(this.panel19, 1);
            this.panel19.Controls.Add(this.label19);
            this.panel19.Controls.Add(this.txbThanhTien);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel19.Location = new System.Drawing.Point(273, 55);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel19.Name = "panel19";
            this.tablePanel6.SetRow(this.panel19, 1);
            this.panel19.Size = new System.Drawing.Size(261, 49);
            this.panel19.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Thành tiền:";
            // 
            // txbThanhTien
            // 
            this.txbThanhTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbThanhTien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThanhTien.Location = new System.Drawing.Point(0, 21);
            this.txbThanhTien.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbThanhTien.Name = "txbThanhTien";
            this.txbThanhTien.Size = new System.Drawing.Size(261, 28);
            this.txbThanhTien.TabIndex = 1;
            // 
            // panel20
            // 
            this.tablePanel6.SetColumn(this.panel20, 2);
            this.panel20.Controls.Add(this.txbSDT);
            this.panel20.Controls.Add(this.label20);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel20.Location = new System.Drawing.Point(543, 2);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel20.Name = "panel20";
            this.tablePanel6.SetRow(this.panel20, 0);
            this.panel20.Size = new System.Drawing.Size(261, 49);
            this.panel20.TabIndex = 6;
            // 
            // txbSDT
            // 
            this.txbSDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbSDT.Location = new System.Drawing.Point(0, 21);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Properties.Appearance.Options.UseFont = true;
            this.txbSDT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txbSDT.Properties.MaskSettings.Set("mask", "0\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.txbSDT.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbSDT.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txbSDT.Size = new System.Drawing.Size(261, 28);
            this.txbSDT.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Số điện thoại:";
            // 
            // panel21
            // 
            this.tablePanel6.SetColumn(this.panel21, 2);
            this.panel21.Controls.Add(this.txbTenNV);
            this.panel21.Controls.Add(this.label21);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel21.Location = new System.Drawing.Point(543, 55);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel21.Name = "panel21";
            this.tablePanel6.SetRow(this.panel21, 1);
            this.panel21.Size = new System.Drawing.Size(261, 49);
            this.panel21.TabIndex = 3;
            // 
            // txbTenNV
            // 
            this.txbTenNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbTenNV.Location = new System.Drawing.Point(0, 21);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNV.Properties.Appearance.Options.UseFont = true;
            this.txbTenNV.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txbTenNV.Properties.MaskSettings.Set("mask", "([a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA-Z]+)(" +
        "(\\s{1}[a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA" +
        "-Z]+){1,})");
            this.txbTenNV.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txbTenNV.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbTenNV.Size = new System.Drawing.Size(261, 28);
            this.txbTenNV.TabIndex = 9;
            this.txbTenNV.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tên nhân viên:";
            // 
            // danhSachHoaDonTableAdapter
            // 
            this.danhSachHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // dSChiTietHoaDonTableAdapter
            // 
            this.dSChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(958, 500);
            this.Controls.Add(this.tablePanel5);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "frmInvoiceManagement";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.frmInvoiceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeNgayBan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeNgayBan.Properties)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenKH.Properties)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTenNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label22;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txbThanhTien;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridViewDSHD;
        private QuanLyHieuThuocTayDataSet quanLyHieuThuocTayDataSet;
        private System.Windows.Forms.BindingSource danhSachHoaDonBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.DanhSachHoaDonTableAdapter danhSachHoaDonTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewDSCTHD;
        private System.Windows.Forms.BindingSource dSChiTietHoaDonBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.DSChiTietHoaDonTableAdapter dSChiTietHoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn1;
        private DevExpress.XtraEditors.DateEdit dateTimeNgayBan;
        private System.Windows.Forms.Button btnHuy;
        private DevExpress.XtraEditors.TextEdit txbSDT;
        private DevExpress.XtraEditors.TextEdit txbTenKH;
        private DevExpress.XtraEditors.TextEdit txbTenNV;
    }
}