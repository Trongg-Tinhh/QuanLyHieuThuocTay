namespace DXApplication2
{
    partial class frmBanHang
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
            this.tablePanel = new DevExpress.Utils.Layout.TablePanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.listViewChiTietHoaDon = new System.Windows.Forms.ListView();
            this.columnMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhanChinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doTuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHieuThuocTayDataSet = new DXApplication2.QuanLyHieuThuocTayDataSet();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimeEditNgayBan = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbDoTuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbLoaiSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbCongDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.danhSachSanPhamTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.DanhSachSanPhamTableAdapter();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.HoaDonTableAdapter();
            this.chiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietHoaDonTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).BeginInit();
            this.tablePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeEditNgayBan.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.AutoScroll = true;
            this.tablePanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 56F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 43F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.tablePanel.Controls.Add(this.panel6);
            this.tablePanel.Controls.Add(this.listViewChiTietHoaDon);
            this.tablePanel.Controls.Add(this.dgvDanhSachSanPham);
            this.tablePanel.Controls.Add(this.tableLayoutPanel4);
            this.tablePanel.Controls.Add(this.tableLayoutPanel2);
            this.tablePanel.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.MinimumSize = new System.Drawing.Size(1198, 605);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tablePanel.Size = new System.Drawing.Size(1200, 675);
            this.tablePanel.TabIndex = 2;
            // 
            // panel6
            // 
            this.tablePanel.SetColumn(this.panel6, 0);
            this.panel6.Controls.Add(this.btnClearData);
            this.panel6.Controls.Add(this.btnXoaThuoc);
            this.panel6.Location = new System.Drawing.Point(3, 611);
            this.panel6.MinimumSize = new System.Drawing.Size(520, 61);
            this.panel6.Name = "panel6";
            this.tablePanel.SetRow(this.panel6, 2);
            this.panel6.Size = new System.Drawing.Size(666, 61);
            this.panel6.TabIndex = 15;
            // 
            // btnClearData
            // 
            this.btnClearData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClearData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(59, 12);
            this.btnClearData.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(120, 40);
            this.btnClearData.TabIndex = 11;
            this.btnClearData.Text = "Hủy chọn";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaThuoc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuoc.Location = new System.Drawing.Point(495, 10);
            this.btnXoaThuoc.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(120, 40);
            this.btnXoaThuoc.TabIndex = 10;
            this.btnXoaThuoc.Text = "Xóa thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // listViewChiTietHoaDon
            // 
            this.tablePanel.SetColumn(this.listViewChiTietHoaDon, 1);
            this.listViewChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaSP,
            this.columnTenSP,
            this.columnLoaiSP,
            this.columnAmount,
            this.columnPrice});
            this.listViewChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewChiTietHoaDon.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewChiTietHoaDon.FullRowSelect = true;
            this.listViewChiTietHoaDon.HideSelection = false;
            this.listViewChiTietHoaDon.Location = new System.Drawing.Point(675, 138);
            this.listViewChiTietHoaDon.Name = "listViewChiTietHoaDon";
            this.tablePanel.SetRow(this.listViewChiTietHoaDon, 1);
            this.listViewChiTietHoaDon.Size = new System.Drawing.Size(510, 467);
            this.listViewChiTietHoaDon.TabIndex = 14;
            this.listViewChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.listViewChiTietHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnMaSP
            // 
            this.columnMaSP.Text = "Mã sản phẩm";
            this.columnMaSP.Width = 111;
            // 
            // columnTenSP
            // 
            this.columnTenSP.Text = "Tên sản phẩm";
            this.columnTenSP.Width = 127;
            // 
            // columnLoaiSP
            // 
            this.columnLoaiSP.Text = "Loại sản phẩm";
            this.columnLoaiSP.Width = 121;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Số lượng";
            this.columnAmount.Width = 77;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Đơn giá";
            this.columnPrice.Width = 89;
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AllowUserToAddRows = false;
            this.dgvDanhSachSanPham.AllowUserToDeleteRows = false;
            this.dgvDanhSachSanPham.AutoGenerateColumns = false;
            this.dgvDanhSachSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablePanel.SetColumn(this.dgvDanhSachSanPham, 0);
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.congDungDataGridViewTextBoxColumn,
            this.thanhPhanChinhDataGridViewTextBoxColumn,
            this.doTuoiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn});
            this.dgvDanhSachSanPham.DataSource = this.danhSachSanPhamBindingSource;
            this.dgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(3, 138);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.tablePanel.SetRow(this.dgvDanhSachSanPham, 1);
            this.dgvDanhSachSanPham.RowHeadersWidth = 51;
            this.dgvDanhSachSanPham.RowTemplate.Height = 24;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(666, 467);
            this.dgvDanhSachSanPham.TabIndex = 13;
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellContentClick);
            this.dgvDanhSachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellContentClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "maSP";
            this.maSPDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP";
            this.tenSPDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "tenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên loại";
            this.tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            this.tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // congDungDataGridViewTextBoxColumn
            // 
            this.congDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.congDungDataGridViewTextBoxColumn.DataPropertyName = "congDung";
            this.congDungDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.congDungDataGridViewTextBoxColumn.HeaderText = "Công dụng";
            this.congDungDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.congDungDataGridViewTextBoxColumn.Name = "congDungDataGridViewTextBoxColumn";
            this.congDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhPhanChinhDataGridViewTextBoxColumn
            // 
            this.thanhPhanChinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhPhanChinhDataGridViewTextBoxColumn.DataPropertyName = "thanhPhanChinh";
            this.thanhPhanChinhDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.thanhPhanChinhDataGridViewTextBoxColumn.HeaderText = "Thành phần chính";
            this.thanhPhanChinhDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.thanhPhanChinhDataGridViewTextBoxColumn.Name = "thanhPhanChinhDataGridViewTextBoxColumn";
            this.thanhPhanChinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doTuoiDataGridViewTextBoxColumn
            // 
            this.doTuoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doTuoiDataGridViewTextBoxColumn.DataPropertyName = "doTuoi";
            this.doTuoiDataGridViewTextBoxColumn.FillWeight = 37.5F;
            this.doTuoiDataGridViewTextBoxColumn.HeaderText = "Độ tuổi";
            this.doTuoiDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.doTuoiDataGridViewTextBoxColumn.Name = "doTuoiDataGridViewTextBoxColumn";
            this.doTuoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 475F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "donViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.donViTinhDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            this.donViTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.donViTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // danhSachSanPhamBindingSource
            // 
            this.danhSachSanPhamBindingSource.DataMember = "DanhSachSanPham";
            this.danhSachSanPhamBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // quanLyHieuThuocTayDataSet
            // 
            this.quanLyHieuThuocTayDataSet.DataSetName = "QuanLyHieuThuocTayDataSet";
            this.quanLyHieuThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel4
            // 
            this.tablePanel.SetColumn(this.tableLayoutPanel4, 1);
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnThanhToan, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblThanhTien, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(675, 611);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tablePanel.SetRow(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(510, 61);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(67, 10);
            this.btnThanhToan.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 40);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(332, 18);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(101, 24);
            this.lblThanhTien.TabIndex = 10;
            this.lblThanhTien.Text = "thanh tien";
            // 
            // tableLayoutPanel2
            // 
            this.tablePanel.SetColumn(this.tableLayoutPanel2, 1);
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(675, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tablePanel.SetRow(this.tableLayoutPanel2, 0);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.69565F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.86956F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 129);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80159F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19841F));
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(504, 47);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.txbSDT);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(245, 41);
            this.panel9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số điện thoại:";
            // 
            // txbSDT
            // 
            this.txbSDT.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbSDT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(125, 0);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(120, 28);
            this.txbSDT.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTimeEditNgayBan);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(254, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 41);
            this.panel7.TabIndex = 6;
            // 
            // dateTimeEditNgayBan
            // 
            this.dateTimeEditNgayBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimeEditNgayBan.EditValue = null;
            this.dateTimeEditNgayBan.Location = new System.Drawing.Point(91, 0);
            this.dateTimeEditNgayBan.Name = "dateTimeEditNgayBan";
            this.dateTimeEditNgayBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEditNgayBan.Properties.Appearance.Options.UseFont = true;
            this.dateTimeEditNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeEditNgayBan.Properties.MaskSettings.Set("mask", "d");
            this.dateTimeEditNgayBan.Size = new System.Drawing.Size(153, 28);
            this.dateTimeEditNgayBan.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày bán:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.txbTenKH);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 33);
            this.panel8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên khách hàng:";
            // 
            // txbTenKH
            // 
            this.txbTenKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenKH.Location = new System.Drawing.Point(177, 3);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(208, 28);
            this.txbTenKH.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(504, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hóa đơn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablePanel.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnThem, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel.SetRow(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 115);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.numericSoLuong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(447, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 51);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numericSoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSoLuong.Location = new System.Drawing.Point(0, 25);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(216, 26);
            this.numericSoLuong.TabIndex = 3;
            this.numericSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbDoTuoi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(225, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 52);
            this.panel4.TabIndex = 5;
            // 
            // txbDoTuoi
            // 
            this.txbDoTuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbDoTuoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoTuoi.Location = new System.Drawing.Point(0, 24);
            this.txbDoTuoi.Name = "txbDoTuoi";
            this.txbDoTuoi.Size = new System.Drawing.Size(216, 28);
            this.txbDoTuoi.TabIndex = 5;
            this.txbDoTuoi.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Độ tuổi:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbLoaiSP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 51);
            this.panel3.TabIndex = 2;
            // 
            // txbLoaiSP
            // 
            this.txbLoaiSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbLoaiSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoaiSP.Location = new System.Drawing.Point(0, 23);
            this.txbLoaiSP.Name = "txbLoaiSP";
            this.txbLoaiSP.Size = new System.Drawing.Size(216, 28);
            this.txbLoaiSP.TabIndex = 2;
            this.txbLoaiSP.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTenSP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 51);
            this.panel1.TabIndex = 1;
            // 
            // txbTenSP
            // 
            this.txbTenSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbTenSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenSP.Location = new System.Drawing.Point(0, 23);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(216, 28);
            this.txbTenSP.TabIndex = 1;
            this.txbTenSP.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbCongDung);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 52);
            this.panel2.TabIndex = 4;
            // 
            // txbCongDung
            // 
            this.txbCongDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbCongDung.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCongDung.Location = new System.Drawing.Point(0, 24);
            this.txbCongDung.Name = "txbCongDung";
            this.txbCongDung.Size = new System.Drawing.Size(216, 28);
            this.txbCongDung.TabIndex = 4;
            this.txbCongDung.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Công dụng:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(495, 66);
            this.btnThem.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // danhSachSanPhamTableAdapter
            // 
            this.danhSachSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietHoaDonBindingSource
            // 
            this.chiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.chiTietHoaDonBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // chiTietHoaDonTableAdapter
            // 
            this.chiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmBanHang
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearData;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.tablePanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "frmBanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel)).EndInit();
            this.tablePanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeEditNgayBan.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeEditNgayBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private QuanLyHieuThuocTayDataSet quanLyHieuThuocTayDataSet;
        private System.Windows.Forms.BindingSource danhSachSanPhamBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.DanhSachSanPhamTableAdapter danhSachSanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhanChinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doTuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listViewChiTietHoaDon;
        private System.Windows.Forms.ColumnHeader columnTenSP;
        private System.Windows.Forms.ColumnHeader columnLoaiSP;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnMaSP;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.TextBox txbDoTuoi;
        private System.Windows.Forms.TextBox txbLoaiSP;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.TextBox txbCongDung;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.BindingSource chiTietHoaDonBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.ChiTietHoaDonTableAdapter chiTietHoaDonTableAdapter;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnClearData;
    }
}