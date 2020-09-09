namespace AppQuanLyBanCafe
{
    partial class frmQuanLyKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhuVuc));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenBan = new DevExpress.XtraEditors.TextEdit();
            this.grcrlTT = new DevExpress.XtraEditors.GroupControl();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtMaBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tabcrlBan = new System.Windows.Forms.TabControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuuKhu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaKhu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKhu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKhu = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhu = new System.Windows.Forms.TextBox();
            this.txtMaKhu = new System.Windows.Forms.TextBox();
            this.btnHuyBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyKhu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcrlTT)).BeginInit();
            this.grcrlTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnHuyBan);
            this.groupControl2.Controls.Add(this.btnLuu);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Location = new System.Drawing.Point(449, 343);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(579, 178);
            this.groupControl2.TabIndex = 27;
            this.groupControl2.Text = "Xử Lý";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Location = new System.Drawing.Point(462, 76);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 42);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(318, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 42);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(171, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 42);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(29, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 19);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tên Khu Vực";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(146, 104);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Properties.Appearance.Options.UseFont = true;
            this.txtTenBan.Size = new System.Drawing.Size(244, 22);
            this.txtTenBan.TabIndex = 23;
            // 
            // grcrlTT
            // 
            this.grcrlTT.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcrlTT.AppearanceCaption.Options.UseFont = true;
            this.grcrlTT.Controls.Add(this.cboKhuVuc);
            this.grcrlTT.Controls.Add(this.labelControl4);
            this.grcrlTT.Controls.Add(this.txtTenBan);
            this.grcrlTT.Controls.Add(this.txtMaBan);
            this.grcrlTT.Controls.Add(this.labelControl3);
            this.grcrlTT.Controls.Add(this.labelControl13);
            this.grcrlTT.Location = new System.Drawing.Point(449, 82);
            this.grcrlTT.Name = "grcrlTT";
            this.grcrlTT.Size = new System.Drawing.Size(579, 255);
            this.grcrlTT.TabIndex = 26;
            this.grcrlTT.Text = "Thông Tin Bàn";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(146, 152);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(244, 21);
            this.cboKhuVuc.TabIndex = 27;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Enabled = false;
            this.txtMaBan.Location = new System.Drawing.Point(146, 55);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Properties.Appearance.Options.UseFont = true;
            this.txtMaBan.Size = new System.Drawing.Size(244, 22);
            this.txtMaBan.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 19);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Tên Bàn";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(13, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(55, 19);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "Mã Bàn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(0, 1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1028, 75);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "CẬP NHẬT KHU VỰC BÀN";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.tabcrlBan);
            this.groupControl3.Location = new System.Drawing.Point(0, 82);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(443, 439);
            this.groupControl3.TabIndex = 29;
            this.groupControl3.Text = "Khu vực";
            // 
            // tabcrlBan
            // 
            this.tabcrlBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcrlBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcrlBan.Location = new System.Drawing.Point(2, 26);
            this.tabcrlBan.Name = "tabcrlBan";
            this.tabcrlBan.SelectedIndex = 0;
            this.tabcrlBan.Size = new System.Drawing.Size(439, 411);
            this.tabcrlBan.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHuyKhu);
            this.groupControl1.Controls.Add(this.btnLuuKhu);
            this.groupControl1.Controls.Add(this.btnSuaKhu);
            this.groupControl1.Controls.Add(this.btnXoaKhu);
            this.groupControl1.Controls.Add(this.btnThemKhu);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTenKhu);
            this.groupControl1.Controls.Add(this.txtMaKhu);
            this.groupControl1.Location = new System.Drawing.Point(2, 525);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(439, 113);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Cập nhật khu";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnLuuKhu
            // 
            this.btnLuuKhu.Location = new System.Drawing.Point(280, 85);
            this.btnLuuKhu.Name = "btnLuuKhu";
            this.btnLuuKhu.Size = new System.Drawing.Size(75, 23);
            this.btnLuuKhu.TabIndex = 7;
            this.btnLuuKhu.Text = "Lưu";
            this.btnLuuKhu.Click += new System.EventHandler(this.btnLuuKhu_Click);
            // 
            // btnSuaKhu
            // 
            this.btnSuaKhu.Location = new System.Drawing.Point(192, 85);
            this.btnSuaKhu.Name = "btnSuaKhu";
            this.btnSuaKhu.Size = new System.Drawing.Size(75, 23);
            this.btnSuaKhu.TabIndex = 6;
            this.btnSuaKhu.Text = "Sửa";
            this.btnSuaKhu.Click += new System.EventHandler(this.btnSuaKhu_Click);
            // 
            // btnXoaKhu
            // 
            this.btnXoaKhu.Location = new System.Drawing.Point(100, 85);
            this.btnXoaKhu.Name = "btnXoaKhu";
            this.btnXoaKhu.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhu.TabIndex = 5;
            this.btnXoaKhu.Text = "Xóa";
            this.btnXoaKhu.Click += new System.EventHandler(this.btnXoaKhu_Click);
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(10, 85);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(75, 23);
            this.btnThemKhu.TabIndex = 4;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khu";
            // 
            // txtTenKhu
            // 
            this.txtTenKhu.Location = new System.Drawing.Point(189, 42);
            this.txtTenKhu.Name = "txtTenKhu";
            this.txtTenKhu.Size = new System.Drawing.Size(100, 21);
            this.txtTenKhu.TabIndex = 1;
            // 
            // txtMaKhu
            // 
            this.txtMaKhu.Location = new System.Drawing.Point(38, 42);
            this.txtMaKhu.Name = "txtMaKhu";
            this.txtMaKhu.Size = new System.Drawing.Size(100, 21);
            this.txtMaKhu.TabIndex = 0;
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBan.Appearance.Options.UseFont = true;
            this.btnHuyBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnHuyBan.Location = new System.Drawing.Point(213, 131);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(150, 42);
            this.btnHuyBan.TabIndex = 14;
            this.btnHuyBan.Text = "Hủy tác vụ";
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnHuyKhu
            // 
            this.btnHuyKhu.Location = new System.Drawing.Point(364, 85);
            this.btnHuyKhu.Name = "btnHuyKhu";
            this.btnHuyKhu.Size = new System.Drawing.Size(75, 23);
            this.btnHuyKhu.TabIndex = 8;
            this.btnHuyKhu.Text = "Hủy";
            this.btnHuyKhu.Click += new System.EventHandler(this.btnHuyKhu_Click);
            // 
            // frmQuanLyKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 637);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.grcrlTT);
            this.Controls.Add(this.labelControl2);
            this.Name = "frmQuanLyKhuVuc";
            this.Text = "frmQuanLyKhuVuc";
            this.Load += new System.EventHandler(this.frmQuanLyKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcrlTT)).EndInit();
            this.grcrlTT.ResumeLayout(false);
            this.grcrlTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenBan;
        private DevExpress.XtraEditors.GroupControl grcrlTT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TabControl tabcrlBan;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private DevExpress.XtraEditors.TextEdit txtMaBan;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSuaKhu;
        private DevExpress.XtraEditors.SimpleButton btnXoaKhu;
        private DevExpress.XtraEditors.SimpleButton btnThemKhu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhu;
        private System.Windows.Forms.TextBox txtMaKhu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnLuuKhu;
        private DevExpress.XtraEditors.SimpleButton btnHuyBan;
        private DevExpress.XtraEditors.SimpleButton btnHuyKhu;

    }
}