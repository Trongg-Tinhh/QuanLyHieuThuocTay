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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTaiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHieuThuocTayDataSet = new DXApplication2.QuanLyHieuThuocTayDataSet();
            this.label22 = new System.Windows.Forms.Label();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dateTimeOffsetEdit1 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.hoaDonTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel5
            // 
            this.tablePanel5.AutoScroll = true;
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
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
            this.panel23.Controls.Add(this.label23);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(574, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(375, 351);
            this.panel23.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(169, 24);
            this.label23.TabIndex = 10;
            this.label23.Text = "Chi tiết hóa đơn";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.dataGridView1);
            this.panel22.Controls.Add(this.label22);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(565, 351);
            this.panel22.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.tenKhachDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.maTaiKhoanDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 327);
            this.dataGridView1.TabIndex = 11;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "maHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "maHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKhachDataGridViewTextBoxColumn
            // 
            this.tenKhachDataGridViewTextBoxColumn.DataPropertyName = "tenKhach";
            this.tenKhachDataGridViewTextBoxColumn.HeaderText = "tenKhach";
            this.tenKhachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhachDataGridViewTextBoxColumn.Name = "tenKhachDataGridViewTextBoxColumn";
            this.tenKhachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhachDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "ngayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "ngayBan";
            this.ngayBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            this.ngayBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTaiKhoanDataGridViewTextBoxColumn
            // 
            this.maTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "maTaiKhoan";
            this.maTaiKhoanDataGridViewTextBoxColumn.HeaderText = "maTaiKhoan";
            this.maTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTaiKhoanDataGridViewTextBoxColumn.Name = "maTaiKhoanDataGridViewTextBoxColumn";
            this.maTaiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTaiKhoanDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // quanLyHieuThuocTayDataSet
            // 
            this.quanLyHieuThuocTayDataSet.DataSetName = "QuanLyHieuThuocTayDataSet";
            this.quanLyHieuThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(202, 24);
            this.label22.TabIndex = 10;
            this.label22.Text = "Danh sách hóa đơn";
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
            this.panel16.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 28);
            this.textBox1.TabIndex = 2;
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
            this.panel17.Controls.Add(this.dateTimeOffsetEdit1);
            this.panel17.Controls.Add(this.label17);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel17.Location = new System.Drawing.Point(4, 55);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel17.Name = "panel17";
            this.tablePanel6.SetRow(this.panel17, 1);
            this.panel17.Size = new System.Drawing.Size(261, 49);
            this.panel17.TabIndex = 4;
            // 
            // dateTimeOffsetEdit1
            // 
            this.dateTimeOffsetEdit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimeOffsetEdit1.EditValue = null;
            this.dateTimeOffsetEdit1.Location = new System.Drawing.Point(0, 21);
            this.dateTimeOffsetEdit1.Name = "dateTimeOffsetEdit1";
            this.dateTimeOffsetEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOffsetEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateTimeOffsetEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOffsetEdit1.Properties.MaskSettings.Set("mask", "d");
            this.dateTimeOffsetEdit1.Size = new System.Drawing.Size(261, 28);
            this.dateTimeOffsetEdit1.TabIndex = 1;
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
            // panel18
            // 
            this.tablePanel6.SetColumn(this.panel18, 1);
            this.panel18.Controls.Add(this.textBox3);
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
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 21);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 28);
            this.textBox3.TabIndex = 1;
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
            this.panel19.Controls.Add(this.textBox4);
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
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 21);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 28);
            this.textBox4.TabIndex = 1;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // panel20
            // 
            this.tablePanel6.SetColumn(this.panel20, 2);
            this.panel20.Controls.Add(this.textBox5);
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
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 21);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(261, 28);
            this.textBox5.TabIndex = 1;
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
            this.panel21.Controls.Add(this.label21);
            this.panel21.Controls.Add(this.textBox6);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel21.Location = new System.Drawing.Point(543, 55);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel21.Name = "panel21";
            this.tablePanel6.SetRow(this.panel21, 1);
            this.panel21.Size = new System.Drawing.Size(261, 49);
            this.panel21.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 21);
            this.label21.TabIndex = 0;
            this.label21.Text = "Mã nhân viên:";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(0, 21);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(261, 28);
            this.textBox6.TabIndex = 1;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOffsetEdit1.Properties)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel17;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dateTimeOffsetEdit1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuanLyHieuThuocTayDataSet quanLyHieuThuocTayDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTaiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}