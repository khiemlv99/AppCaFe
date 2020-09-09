namespace AppQuanLyBanCafe
{
    partial class frmQuanLyKho
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThongke = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTennguyenlieu = new System.Windows.Forms.TextBox();
            this.txtmanguyenlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdViewNguyenlieu = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.numSoLuongNhom = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.grdViewNhomNguyenLieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemNhomNguyenLieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNguyenlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNhomNguyenLieu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.ImageUri.Uri = "InFrontOfText";
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.grdViewNguyenlieu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(480, 517);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Nhóm Nguyên liệu";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.numSoLuong);
            this.groupControl3.Controls.Add(this.btnHuy);
            this.groupControl3.Controls.Add(this.btnThongke);
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.dateTimePicker1);
            this.groupControl3.Controls.Add(this.label8);
            this.groupControl3.Controls.Add(this.txtDVT);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.txtDonGia);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.btnCapNhat);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.cboTimkiem);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.txtTennguyenlieu);
            this.groupControl3.Controls.Add(this.txtmanguyenlieu);
            this.groupControl3.Location = new System.Drawing.Point(2, 89);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(476, 294);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Thêm Nhóm Tài khoản";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(65, 87);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(85, 21);
            this.numSoLuong.TabIndex = 22;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(401, 203);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy tác vụ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(253, 237);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(111, 34);
            this.btnThongke.TabIndex = 20;
            this.btnThongke.Text = "Thông kê nhập kho";
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày nhập";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Đơn vị tính";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(315, 91);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(78, 21);
            this.txtDVT.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(65, 123);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(85, 21);
            this.txtDonGia.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã nguyên liệu";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(315, 203);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm theo mã";
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Location = new System.Drawing.Point(13, 250);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(189, 21);
            this.cboTimkiem.TabIndex = 2;
            this.cboTimkiem.SelectionChangeCommitted += new System.EventHandler(this.cboTimkiem_SelectionChangeCommitted);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(210, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(117, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên nguyên liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // txtTennguyenlieu
            // 
            this.txtTennguyenlieu.Location = new System.Drawing.Point(253, 58);
            this.txtTennguyenlieu.Name = "txtTennguyenlieu";
            this.txtTennguyenlieu.Size = new System.Drawing.Size(140, 21);
            this.txtTennguyenlieu.TabIndex = 1;
            // 
            // txtmanguyenlieu
            // 
            this.txtmanguyenlieu.Location = new System.Drawing.Point(12, 56);
            this.txtmanguyenlieu.Name = "txtmanguyenlieu";
            this.txtmanguyenlieu.Size = new System.Drawing.Size(138, 21);
            this.txtmanguyenlieu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = " Quản lý kho nguyên liệu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdViewNguyenlieu
            // 
            this.grdViewNguyenlieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViewNguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewNguyenlieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdViewNguyenlieu.Location = new System.Drawing.Point(2, 231);
            this.grdViewNguyenlieu.Name = "grdViewNguyenlieu";
            this.grdViewNguyenlieu.Size = new System.Drawing.Size(476, 284);
            this.grdViewNguyenlieu.TabIndex = 0;
            this.grdViewNguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewNguyenlieu_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.numSoLuongNhom);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.grdViewNhomNguyenLieu);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.cboMaMon);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(589, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(490, 517);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Quản lý nhóm nguyên liệu";
            // 
            // numSoLuongNhom
            // 
            this.numSoLuongNhom.Location = new System.Drawing.Point(268, 142);
            this.numSoLuongNhom.Name = "numSoLuongNhom";
            this.numSoLuongNhom.Size = new System.Drawing.Size(93, 21);
            this.numSoLuongNhom.TabIndex = 23;
            this.numSoLuongNhom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(391, 136);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(79, 30);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Cập nhật";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số lượng cần dùng";
            // 
            // grdViewNhomNguyenLieu
            // 
            this.grdViewNhomNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViewNhomNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewNhomNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdViewNhomNguyenLieu.ContextMenuStrip = this.contextMenuStrip1;
            this.grdViewNhomNguyenLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdViewNhomNguyenLieu.Location = new System.Drawing.Point(2, 172);
            this.grdViewNhomNguyenLieu.Name = "grdViewNhomNguyenLieu";
            this.grdViewNhomNguyenLieu.Size = new System.Drawing.Size(486, 343);
            this.grdViewNhomNguyenLieu.TabIndex = 6;
            this.grdViewNhomNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewNhomNguyenLieu_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMon";
            this.Column1.HeaderText = "Mã món ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNguyenLieu";
            this.Column2.HeaderText = "Mã nguyên liệu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuongSuDung";
            this.Column3.HeaderText = "Số lượng sử dụng";
            this.Column3.Name = "Column3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // menuXoa
            // 
            this.menuXoa.Name = "menuXoa";
            this.menuXoa.Size = new System.Drawing.Size(94, 22);
            this.menuXoa.Text = "Xóa";
            this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Chọn món cần thêm nguyên liệu";
            // 
            // cboMaMon
            // 
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Location = new System.Drawing.Point(21, 141);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(189, 21);
            this.cboMaMon.TabIndex = 4;
            this.cboMaMon.SelectionChangeCommitted += new System.EventHandler(this.cboMaMon_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(486, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = " Quản lý nhóm nguyên liệu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemNhomNguyenLieu
            // 
            this.btnThemNhomNguyenLieu.Location = new System.Drawing.Point(474, 337);
            this.btnThemNhomNguyenLieu.Name = "btnThemNhomNguyenLieu";
            this.btnThemNhomNguyenLieu.Size = new System.Drawing.Size(111, 52);
            this.btnThemNhomNguyenLieu.TabIndex = 6;
            this.btnThemNhomNguyenLieu.Text = "Thêm";
            this.btnThemNhomNguyenLieu.Click += new System.EventHandler(this.btnThemNhomNguyenLieu_Click);
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 517);
            this.Controls.Add(this.btnThemNhomNguyenLieu);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmQuanLyKho";
            this.Text = "frmQuanLyKho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNguyenlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNhomNguyenLieu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTimkiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTennguyenlieu;
        private System.Windows.Forms.TextBox txtmanguyenlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdViewNguyenlieu;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMaMon;
        private DevExpress.XtraEditors.SimpleButton btnThemNhomNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView grdViewNhomNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraEditors.SimpleButton btnThongke;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuongNhom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
    }
}