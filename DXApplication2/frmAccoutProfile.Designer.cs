namespace DXApplication2
{
    partial class frmAccoutProfile
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbCCCD = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbSDT = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyHieuThuocTayDataSet = new DXApplication2.QuanLyHieuThuocTayDataSet();
            this.taiKhoanTableAdapter = new DXApplication2.QuanLyHieuThuocTayDataSetTableAdapters.TaiKhoanTableAdapter();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbCCCD.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(501, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thông tin tài khoản";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnHuy);
            this.panel10.Controls.Add(this.btnSua);
            this.panel10.Controls.Add(this.btnLuu);
            this.panel10.Location = new System.Drawing.Point(5, 298);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(484, 62);
            this.panel10.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(340, 0);
            this.btnHuy.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(24, 0);
            this.btnSua.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(183, 0);
            this.btnLuu.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbCCCD);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(5, 225);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(484, 63);
            this.panel8.TabIndex = 3;
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(183, 18);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCCCD.Properties.Appearance.Options.UseFont = true;
            this.txbCCCD.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txbCCCD.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.txbCCCD.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbCCCD.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txbCCCD.Size = new System.Drawing.Size(275, 30);
            this.txbCCCD.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "CCCD/CMND:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbSDT);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(5, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 63);
            this.panel7.TabIndex = 2;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(185, 19);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Properties.Appearance.Options.UseFont = true;
            this.txbSDT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txbSDT.Properties.MaskSettings.Set("mask", "0\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.txbSDT.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbSDT.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txbSDT.Size = new System.Drawing.Size(275, 30);
            this.txbSDT.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(37, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số điện thoại:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 63);
            this.panel2.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(184, 19);
            this.txbName.Name = "txbName";
            this.txbName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Properties.Appearance.Options.UseFont = true;
            this.txbName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txbName.Properties.MaskSettings.Set("mask", "([a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA-Z]+)(" +
        "(\\s{1}[a-vxyỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđA" +
        "-Z]+){1,})");
            this.txbName.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txbName.Properties.MaskSettings.Set("placeholder", '\0');
            this.txbName.Size = new System.Drawing.Size(275, 30);
            this.txbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hiển thị:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 63);
            this.panel1.TabIndex = 11;
            // 
            // txbUserName
            // 
            this.txbUserName.AutoSize = true;
            this.txbUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(180, 21);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(130, 24);
            this.txbUserName.TabIndex = 2;
            this.txbUserName.Text = "txbUserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.quanLyHieuThuocTayDataSet;
            // 
            // quanLyHieuThuocTayDataSet
            // 
            this.quanLyHieuThuocTayDataSet.DataSetName = "QuanLyHieuThuocTayDataSet";
            this.quanLyHieuThuocTayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // frmAccoutProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(503, 483);
            this.MinimumSize = new System.Drawing.Size(503, 483);
            this.Name = "frmAccoutProfile";
            this.Text = "Thông tin các nhân";
            this.Load += new System.EventHandler(this.frmAccoutProfile_Load);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbCCCD.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbSDT.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbName.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHieuThuocTayDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txbUserName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private QuanLyHieuThuocTayDataSet quanLyHieuThuocTayDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QuanLyHieuThuocTayDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraEditors.TextEdit txbName;
        private DevExpress.XtraEditors.TextEdit txbSDT;
        private DevExpress.XtraEditors.TextEdit txbCCCD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}