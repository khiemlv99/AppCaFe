namespace AppQuanLyBanCafe
{
    partial class frmPhanQuyen
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
            this.grdViewNhomTaiKhoan = new System.Windows.Forms.DataGridView();
            this.grdviewPhanQuyen = new System.Windows.Forms.DataGridView();
            this.MaManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoQuyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhomNV = new System.Windows.Forms.TextBox();
            this.txtNhomNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTimkiemTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaManHinh = new System.Windows.Forms.TextBox();
            this.txtMaNhomNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaManHinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTimKiemTheoMaMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNhomTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewNhomTaiKhoan
            // 
            this.grdViewNhomTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdViewNhomTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewNhomTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdViewNhomTaiKhoan.Location = new System.Drawing.Point(2, 110);
            this.grdViewNhomTaiKhoan.Name = "grdViewNhomTaiKhoan";
            this.grdViewNhomTaiKhoan.Size = new System.Drawing.Size(343, 435);
            this.grdViewNhomTaiKhoan.TabIndex = 0;
            this.grdViewNhomTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewNhomTaiKhoan_CellClick);
            // 
            // grdviewPhanQuyen
            // 
            this.grdviewPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdviewPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaManHinh,
            this.Column1,
            this.Column2,
            this.TenManHinh,
            this.CoQuyen});
            this.grdviewPhanQuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdviewPhanQuyen.Location = new System.Drawing.Point(2, 106);
            this.grdviewPhanQuyen.Name = "grdviewPhanQuyen";
            this.grdviewPhanQuyen.Size = new System.Drawing.Size(626, 439);
            this.grdviewPhanQuyen.TabIndex = 1;
            this.grdviewPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewPhanQuyen_CellClick);
            this.grdviewPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewPhanQuyen_CellContentClick);
            // 
            // MaManHinh
            // 
            this.MaManHinh.DataPropertyName = "MaManHinh";
            this.MaManHinh.FillWeight = 60.9137F;
            this.MaManHinh.HeaderText = "Mã Màn hình";
            this.MaManHinh.Name = "MaManHinh";
            this.MaManHinh.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenNhomNV";
            this.Column1.HeaderText = "Tên Nhóm Nhân Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhomNV";
            this.Column2.HeaderText = "Mã nhóm nhân viên";
            this.Column2.Name = "Column2";
            // 
            // TenManHinh
            // 
            this.TenManHinh.DataPropertyName = "TenManHinh";
            this.TenManHinh.FillWeight = 188.7617F;
            this.TenManHinh.HeaderText = "Tên Màn hình";
            this.TenManHinh.Name = "TenManHinh";
            this.TenManHinh.ReadOnly = true;
            // 
            // CoQuyen
            // 
            this.CoQuyen.DataPropertyName = "CoQuyen";
            this.CoQuyen.FillWeight = 75.16231F;
            this.CoQuyen.HeaderText = "Phân quyền";
            this.CoQuyen.Name = "CoQuyen";
            this.CoQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(474, 39);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.ImageUri.Uri = "InFrontOfText";
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cboTimkiemTaiKhoan);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.grdViewNhomTaiKhoan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(347, 547);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Nhóm Tài khoản";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnHuy);
            this.groupControl3.Controls.Add(this.btnCapNhat);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.txtTenNhomNV);
            this.groupControl3.Controls.Add(this.txtNhomNV);
            this.groupControl3.Location = new System.Drawing.Point(0, 79);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(345, 144);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Thêm Nhóm Tài khoản";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(255, 93);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(174, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(93, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 93);
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
            this.label7.Location = new System.Drawing.Point(192, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên nhóm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã nhóm";
            // 
            // txtTenNhomNV
            // 
            this.txtTenNhomNV.Location = new System.Drawing.Point(195, 58);
            this.txtTenNhomNV.Name = "txtTenNhomNV";
            this.txtTenNhomNV.Size = new System.Drawing.Size(140, 21);
            this.txtTenNhomNV.TabIndex = 1;
            // 
            // txtNhomNV
            // 
            this.txtNhomNV.Location = new System.Drawing.Point(12, 56);
            this.txtNhomNV.Name = "txtNhomNV";
            this.txtNhomNV.Size = new System.Drawing.Size(138, 21);
            this.txtNhomNV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm theo NHóm";
            // 
            // cboTimkiemTaiKhoan
            // 
            this.cboTimkiemTaiKhoan.FormattingEnabled = true;
            this.cboTimkiemTaiKhoan.Location = new System.Drawing.Point(17, 247);
            this.cboTimkiemTaiKhoan.Name = "cboTimkiemTaiKhoan";
            this.cboTimkiemTaiKhoan.Size = new System.Drawing.Size(189, 21);
            this.cboTimkiemTaiKhoan.TabIndex = 2;
            this.cboTimkiemTaiKhoan.SelectionChangeCommitted += new System.EventHandler(this.cboTimkiemTaiKhoan_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý nhóm tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.ImageUri.Uri = "Up";
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.cboMaManHinh);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.cboTimKiemTheoMaMH);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.grdviewPhanQuyen);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(353, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(630, 547);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Phân quyền cho nhân viên";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.checkBox1);
            this.groupControl4.Controls.Add(this.label9);
            this.groupControl4.Controls.Add(this.label8);
            this.groupControl4.Controls.Add(this.txtMaManHinh);
            this.groupControl4.Controls.Add(this.txtMaNhomNV);
            this.groupControl4.Controls.Add(this.btnLuu);
            this.groupControl4.Location = new System.Drawing.Point(2, 133);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(628, 90);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "Thêm phân quyền";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(294, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Phân quyền";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã tên màn hình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã nhóm NV";
            // 
            // txtMaManHinh
            // 
            this.txtMaManHinh.Location = new System.Drawing.Point(157, 54);
            this.txtMaManHinh.Name = "txtMaManHinh";
            this.txtMaManHinh.Size = new System.Drawing.Size(100, 21);
            this.txtMaManHinh.TabIndex = 4;
            // 
            // txtMaNhomNV
            // 
            this.txtMaNhomNV.Location = new System.Drawing.Point(28, 54);
            this.txtMaNhomNV.Name = "txtMaNhomNV";
            this.txtMaNhomNV.Size = new System.Drawing.Size(100, 21);
            this.txtMaNhomNV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tìm kiếm theo mã màn hình";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboMaManHinh
            // 
            this.cboMaManHinh.FormattingEnabled = true;
            this.cboMaManHinh.Location = new System.Drawing.Point(280, 106);
            this.cboMaManHinh.Name = "cboMaManHinh";
            this.cboMaManHinh.Size = new System.Drawing.Size(198, 21);
            this.cboMaManHinh.TabIndex = 5;
            this.cboMaManHinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboMaManHinh.SelectionChangeCommitted += new System.EventHandler(this.cboMaManHinh_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tìm kiếm theo mã nhóm";
            // 
            // cboTimKiemTheoMaMH
            // 
            this.cboTimKiemTheoMaMH.FormattingEnabled = true;
            this.cboTimKiemTheoMaMH.Location = new System.Drawing.Point(30, 106);
            this.cboTimKiemTheoMaMH.Name = "cboTimKiemTheoMaMH";
            this.cboTimKiemTheoMaMH.Size = new System.Drawing.Size(198, 21);
            this.cboTimKiemTheoMaMH.TabIndex = 3;
            this.cboTimKiemTheoMaMH.SelectionChangeCommitted += new System.EventHandler(this.cboTimKiemTheoMaMH_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý phân quyền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(131, 121);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy tác vụ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 547);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewNhomTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewNhomTaiKhoan;
        private System.Windows.Forms.DataGridView grdviewPhanQuyen;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTimkiemTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTimKiemTheoMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaManHinh;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhomNV;
        private System.Windows.Forms.TextBox txtNhomNV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaManHinh;
        private System.Windows.Forms.TextBox txtMaNhomNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoQuyen;
        private System.Windows.Forms.Button btnHuy;
    }
}