namespace AppQuanLyBanCafe
{
    partial class frmChiTietDatMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietDatMon));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtgThucDonDat = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTroVe = new DevExpress.XtraEditors.SimpleButton();
            this.numericUpDownThem = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemMon = new DevExpress.XtraEditors.SimpleButton();
            this.groupChiTietBan = new DevExpress.XtraEditors.GroupControl();
            this.dtgMonDaGoi = new System.Windows.Forms.DataGridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoaMon = new DevExpress.XtraEditors.SimpleButton();
            this.updownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatMon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThucDonDat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChiTietBan)).BeginInit();
            this.groupChiTietBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonDaGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.dtgThucDonDat);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(352, 498);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách món";
            // 
            // dtgThucDonDat
            // 
            this.dtgThucDonDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgThucDonDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThucDonDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.Gia,
            this.DVT,
            this.HinhAnh});
            this.dtgThucDonDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgThucDonDat.Location = new System.Drawing.Point(2, 37);
            this.dtgThucDonDat.Name = "dtgThucDonDat";
            this.dtgThucDonDat.Size = new System.Drawing.Size(348, 459);
            this.dtgThucDonDat.TabIndex = 1;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.Name = "TenMon";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.Name = "DVT";
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 459);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm:";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.btnTroVe);
            this.groupControl2.Controls.Add(this.numericUpDownThem);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.btnThemMon);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(352, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(174, 498);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thêm món";
            // 
            // btnTroVe
            // 
            this.btnTroVe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTroVe.ImageOptions.SvgImage")));
            this.btnTroVe.Location = new System.Drawing.Point(0, 390);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(174, 38);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở về ";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // numericUpDownThem
            // 
            this.numericUpDownThem.Location = new System.Drawing.Point(65, 182);
            this.numericUpDownThem.Name = "numericUpDownThem";
            this.numericUpDownThem.Size = new System.Drawing.Size(85, 21);
            this.numericUpDownThem.TabIndex = 6;
            this.numericUpDownThem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // btnThemMon
            // 
            this.btnThemMon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemMon.ImageOptions.SvgImage")));
            this.btnThemMon.Location = new System.Drawing.Point(0, 262);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(174, 38);
            this.btnThemMon.TabIndex = 0;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // groupChiTietBan
            // 
            this.groupChiTietBan.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupChiTietBan.CaptionImageOptions.Image")));
            this.groupChiTietBan.Controls.Add(this.dtgMonDaGoi);
            this.groupChiTietBan.Controls.Add(this.groupControl4);
            this.groupChiTietBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupChiTietBan.Location = new System.Drawing.Point(526, 0);
            this.groupChiTietBan.Name = "groupChiTietBan";
            this.groupChiTietBan.Size = new System.Drawing.Size(465, 498);
            this.groupChiTietBan.TabIndex = 2;
            this.groupChiTietBan.Text = "Chi tiết bàn";
            // 
            // dtgMonDaGoi
            // 
            this.dtgMonDaGoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMonDaGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMonDaGoi.Location = new System.Drawing.Point(2, 153);
            this.dtgMonDaGoi.Name = "dtgMonDaGoi";
            this.dtgMonDaGoi.Size = new System.Drawing.Size(461, 343);
            this.dtgMonDaGoi.TabIndex = 1;
            this.dtgMonDaGoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMonDaGoi_CellClick);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnXoaMon);
            this.groupControl4.Controls.Add(this.btnCapNhatMon);
            this.groupControl4.Controls.Add(this.updownSoLuong);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(2, 37);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(461, 457);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Cập nhật món";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(366, 48);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(85, 32);
            this.btnXoaMon.TabIndex = 4;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // updownSoLuong
            // 
            this.updownSoLuong.Location = new System.Drawing.Point(88, 55);
            this.updownSoLuong.Name = "updownSoLuong";
            this.updownSoLuong.Size = new System.Drawing.Size(134, 21);
            this.updownSoLuong.TabIndex = 2;
            this.updownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownSoLuong.ValueChanged += new System.EventHandler(this.updownSoLuong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhatMon
            // 
            this.btnCapNhatMon.Location = new System.Drawing.Point(248, 48);
            this.btnCapNhatMon.Name = "btnCapNhatMon";
            this.btnCapNhatMon.Size = new System.Drawing.Size(85, 32);
            this.btnCapNhatMon.TabIndex = 3;
            this.btnCapNhatMon.Text = "Cập nhật";
            this.btnCapNhatMon.Click += new System.EventHandler(this.btnCapNhatMon_Click);
            // 
            // frmChiTietDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 498);
            this.Controls.Add(this.groupChiTietBan);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmChiTietDatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietDatMon";
            this.Load += new System.EventHandler(this.frmChiTietDatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThucDonDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChiTietBan)).EndInit();
            this.groupChiTietBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonDaGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dtgThucDonDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnThemMon;
        private DevExpress.XtraEditors.GroupControl groupChiTietBan;
        private System.Windows.Forms.DataGridView dtgMonDaGoi;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnXoaMon;
        private System.Windows.Forms.NumericUpDown updownSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownThem;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatMon;

    }
}