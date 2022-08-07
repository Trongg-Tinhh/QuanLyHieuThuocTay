namespace DXApplication2
{
    partial class frmProductManagement
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
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhanChinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doTuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhSachSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHieuThuocTayDataSet = new DXApplication2.QuanLyHieuThuocTayDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbThanhPhan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbMoTo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.cmbDonVi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbCongDung = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txbNSX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txbDoTuoi = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.danhSachSanPhamTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.DanhSachSanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel3
            // 
            this.tablePanel3.AutoScroll = true;
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 86.7F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 13.3F)});
            this.tablePanel3.Controls.Add(this.dataGridView1);
            this.tablePanel3.Controls.Add(this.label1);
            this.tablePanel3.Controls.Add(this.tablePanel4);
            this.tablePanel3.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 0);
            this.tablePanel3.MinimumSize = new System.Drawing.Size(958, 560);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 63.52F)});
            this.tablePanel3.Size = new System.Drawing.Size(958, 560);
            this.tablePanel3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablePanel3.SetColumn(this.dataGridView1, 0);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.congDungDataGridViewTextBoxColumn,
            this.thanhPhanChinhDataGridViewTextBoxColumn,
            this.doTuoiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.maNSXDataGridViewTextBoxColumn,
            this.tenNSXDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.danhSachSanPhamBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tablePanel3.SetRow(this.dataGridView1, 2);
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 346);
            this.dataGridView1.TabIndex = 10;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "maSP";
            this.maSPDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP";
            this.tenSPDataGridViewTextBoxColumn.FillWeight = 194.1176F;
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm ";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenSPDataGridViewTextBoxColumn.Width = 300;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "maLoai";
            this.maLoaiDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maLoaiDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLoaiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maLoaiDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "tenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên loại";
            this.tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            this.tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiDataGridViewTextBoxColumn.Width = 200;
            // 
            // congDungDataGridViewTextBoxColumn
            // 
            this.congDungDataGridViewTextBoxColumn.DataPropertyName = "congDung";
            this.congDungDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.congDungDataGridViewTextBoxColumn.HeaderText = "Công dụng";
            this.congDungDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.congDungDataGridViewTextBoxColumn.Name = "congDungDataGridViewTextBoxColumn";
            this.congDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.congDungDataGridViewTextBoxColumn.Width = 300;
            // 
            // thanhPhanChinhDataGridViewTextBoxColumn
            // 
            this.thanhPhanChinhDataGridViewTextBoxColumn.DataPropertyName = "thanhPhanChinh";
            this.thanhPhanChinhDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.thanhPhanChinhDataGridViewTextBoxColumn.HeaderText = "Thành phần chính";
            this.thanhPhanChinhDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.thanhPhanChinhDataGridViewTextBoxColumn.Name = "thanhPhanChinhDataGridViewTextBoxColumn";
            this.thanhPhanChinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhPhanChinhDataGridViewTextBoxColumn.Width = 200;
            // 
            // doTuoiDataGridViewTextBoxColumn
            // 
            this.doTuoiDataGridViewTextBoxColumn.DataPropertyName = "doTuoi";
            this.doTuoiDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.doTuoiDataGridViewTextBoxColumn.HeaderText = "Độ tuổi";
            this.doTuoiDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.doTuoiDataGridViewTextBoxColumn.Name = "doTuoiDataGridViewTextBoxColumn";
            this.doTuoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.doTuoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "donViTinh";
            this.donViTinhDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.donViTinhDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            this.donViTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.donViTinhDataGridViewTextBoxColumn.Width = 80;
            // 
            // maNSXDataGridViewTextBoxColumn
            // 
            this.maNSXDataGridViewTextBoxColumn.DataPropertyName = "maNSX";
            this.maNSXDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.maNSXDataGridViewTextBoxColumn.HeaderText = "Mã nhà sản xuất";
            this.maNSXDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.maNSXDataGridViewTextBoxColumn.Name = "maNSXDataGridViewTextBoxColumn";
            this.maNSXDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNSXDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenNSXDataGridViewTextBoxColumn
            // 
            this.tenNSXDataGridViewTextBoxColumn.DataPropertyName = "tenNSX";
            this.tenNSXDataGridViewTextBoxColumn.FillWeight = 90.58823F;
            this.tenNSXDataGridViewTextBoxColumn.HeaderText = "Tên nhà sản xuất";
            this.tenNSXDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.tenNSXDataGridViewTextBoxColumn.Name = "tenNSXDataGridViewTextBoxColumn";
            this.tenNSXDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNSXDataGridViewTextBoxColumn.Width = 400;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel3.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel3.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(825, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablePanel4
            // 
            this.tablePanel4.AutoScroll = true;
            this.tablePanel3.SetColumn(this.tablePanel4, 0);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Controls.Add(this.panel6);
            this.tablePanel4.Controls.Add(this.panel8);
            this.tablePanel4.Controls.Add(this.panel14);
            this.tablePanel4.Controls.Add(this.panel13);
            this.tablePanel4.Controls.Add(this.panel9);
            this.tablePanel4.Controls.Add(this.panel10);
            this.tablePanel4.Controls.Add(this.panel11);
            this.tablePanel4.Controls.Add(this.panel12);
            this.tablePanel4.Controls.Add(this.panel15);
            this.tablePanel4.Location = new System.Drawing.Point(3, 31);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel3.SetRow(this.tablePanel4, 1);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel4.Size = new System.Drawing.Size(825, 174);
            this.tablePanel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.tablePanel4.SetColumn(this.panel6, 0);
            this.panel6.Controls.Add(this.txbTenSP);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(4, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel6.Name = "panel6";
            this.tablePanel4.SetRow(this.panel6, 0);
            this.panel6.Size = new System.Drawing.Size(267, 54);
            this.panel6.TabIndex = 0;
            // 
            // txbTenSP
            // 
            this.txbTenSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbTenSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenSP.Location = new System.Drawing.Point(0, 26);
            this.txbTenSP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(267, 28);
            this.txbTenSP.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // panel8
            // 
            this.tablePanel4.SetColumn(this.panel8, 0);
            this.panel8.Controls.Add(this.txbThanhPhan);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(4, 60);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel8.Name = "panel8";
            this.tablePanel4.SetRow(this.panel8, 1);
            this.panel8.Size = new System.Drawing.Size(267, 54);
            this.panel8.TabIndex = 4;
            // 
            // txbThanhPhan
            // 
            this.txbThanhPhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbThanhPhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThanhPhan.Location = new System.Drawing.Point(0, 26);
            this.txbThanhPhan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbThanhPhan.Name = "txbThanhPhan";
            this.txbThanhPhan.Size = new System.Drawing.Size(267, 28);
            this.txbThanhPhan.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thành phần chính";
            // 
            // panel14
            // 
            this.tablePanel4.SetColumn(this.panel14, 2);
            this.panel14.Controls.Add(this.txbMoTo);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(554, 118);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel14.Name = "panel14";
            this.tablePanel4.SetRow(this.panel14, 2);
            this.panel14.Size = new System.Drawing.Size(267, 54);
            this.panel14.TabIndex = 6;
            // 
            // txbMoTo
            // 
            this.txbMoTo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbMoTo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoTo.Location = new System.Drawing.Point(0, 26);
            this.txbMoTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbMoTo.Name = "txbMoTo";
            this.txbMoTo.Size = new System.Drawing.Size(267, 28);
            this.txbMoTo.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mô tả:";
            // 
            // panel13
            // 
            this.tablePanel4.SetColumn(this.panel13, 1);
            this.panel13.Controls.Add(this.cmbDonVi);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(279, 118);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel13.Name = "panel13";
            this.tablePanel4.SetRow(this.panel13, 2);
            this.panel13.Size = new System.Drawing.Size(267, 54);
            this.panel13.TabIndex = 6;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbDonVi.FormattingEnabled = true;
            this.cmbDonVi.Location = new System.Drawing.Point(0, 25);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Size = new System.Drawing.Size(267, 29);
            this.cmbDonVi.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Đơn vị tính";
            // 
            // panel9
            // 
            this.tablePanel4.SetColumn(this.panel9, 1);
            this.panel9.Controls.Add(this.cmbLoaiSP);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(279, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel9.Name = "panel9";
            this.tablePanel4.SetRow(this.panel9, 0);
            this.panel9.Size = new System.Drawing.Size(267, 54);
            this.panel9.TabIndex = 1;
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Items.AddRange(new object[] {
            "thuoc",
            "1",
            "4",
            "4"});
            this.cmbLoaiSP.Location = new System.Drawing.Point(0, 25);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(267, 29);
            this.cmbLoaiSP.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại sản phẩm:";
            // 
            // panel10
            // 
            this.tablePanel4.SetColumn(this.panel10, 1);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txbCongDung);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(279, 60);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel10.Name = "panel10";
            this.tablePanel4.SetRow(this.panel10, 1);
            this.panel10.Size = new System.Drawing.Size(267, 54);
            this.panel10.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Công dụng";
            // 
            // txbCongDung
            // 
            this.txbCongDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbCongDung.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCongDung.Location = new System.Drawing.Point(0, 26);
            this.txbCongDung.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbCongDung.Name = "txbCongDung";
            this.txbCongDung.Size = new System.Drawing.Size(267, 28);
            this.txbCongDung.TabIndex = 1;
            this.txbCongDung.UseSystemPasswordChar = true;
            // 
            // panel11
            // 
            this.tablePanel4.SetColumn(this.panel11, 2);
            this.panel11.Controls.Add(this.txbNSX);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(554, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel11.Name = "panel11";
            this.tablePanel4.SetRow(this.panel11, 0);
            this.panel11.Size = new System.Drawing.Size(267, 54);
            this.panel11.TabIndex = 6;
            // 
            // txbNSX
            // 
            this.txbNSX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbNSX.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNSX.Location = new System.Drawing.Point(0, 26);
            this.txbNSX.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbNSX.Name = "txbNSX";
            this.txbNSX.Size = new System.Drawing.Size(267, 28);
            this.txbNSX.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhà sản xuất:";
            // 
            // panel12
            // 
            this.tablePanel4.SetColumn(this.panel12, 2);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.txbDoTuoi);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(554, 60);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel12.Name = "panel12";
            this.tablePanel4.SetRow(this.panel12, 1);
            this.panel12.Size = new System.Drawing.Size(267, 54);
            this.panel12.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Độ tuổi:";
            // 
            // txbDoTuoi
            // 
            this.txbDoTuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbDoTuoi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDoTuoi.Location = new System.Drawing.Point(0, 26);
            this.txbDoTuoi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txbDoTuoi.Name = "txbDoTuoi";
            this.txbDoTuoi.Size = new System.Drawing.Size(267, 28);
            this.txbDoTuoi.TabIndex = 1;
            // 
            // panel15
            // 
            this.tablePanel4.SetColumn(this.panel15, 0);
            this.panel15.Controls.Add(this.nudSoLuong);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.Location = new System.Drawing.Point(4, 118);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel15.Name = "panel15";
            this.tablePanel4.SetRow(this.panel15, 2);
            this.panel15.Size = new System.Drawing.Size(267, 54);
            this.panel15.TabIndex = 6;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nudSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(0, 26);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(267, 28);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Số lượng:";
            // 
            // tableLayoutPanel1
            // 
            this.tablePanel3.SetColumn(this.tableLayoutPanel1, 1);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnHuy, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(834, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel3.SetRow(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(121, 298);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 51);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.MinimumSize = new System.Drawing.Size(120, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.MinimumSize = new System.Drawing.Size(120, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 149);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.MinimumSize = new System.Drawing.Size(120, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(4, 100);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button5.MinimumSize = new System.Drawing.Size(120, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 40);
            this.button5.TabIndex = 9;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.MinimumSize = new System.Drawing.Size(120, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(4, 198);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHuy.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // danhSachSanPhamTableAdapter
            // 
            this.danhSachSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 560);
            this.Controls.Add(this.tablePanel3);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "frmProductManagement";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbThanhPhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbMoTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cmbDonVi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbCongDung;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txbNSX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbDoTuoi;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyHieuThuocTayDataSet quanLyHieuThuocTayDataSet;
        private System.Windows.Forms.BindingSource danhSachSanPhamBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.DanhSachSanPhamTableAdapter danhSachSanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhanChinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doTuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNSXDataGridViewTextBoxColumn;
    }
}