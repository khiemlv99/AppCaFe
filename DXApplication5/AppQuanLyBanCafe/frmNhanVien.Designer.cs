namespace AppQuanLyBanCafe
{
    partial class frmNhanVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhomNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTimkiemNhóm = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCaLamViec = new System.Windows.Forms.ComboBox();
            this.btnThemPhanCong = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnLuong = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnHopDong = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 278);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnHopDong);
            this.groupControl3.Controls.Add(this.btnCapNhat);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.cboNhomNV);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.cboTimkiemNhóm);
            this.groupControl3.Controls.Add(this.btnSua);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.btnThem);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Controls.Add(this.txtTenNhanVien);
            this.groupControl3.Controls.Add(this.txtMaNhanVien);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 366);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(862, 144);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Thêm Nhóm Tài khoản";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(343, 93);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên nhóm quyền nhân viên";
            // 
            // cboNhomNV
            // 
            this.cboNhomNV.FormattingEnabled = true;
            this.cboNhomNV.Location = new System.Drawing.Point(374, 58);
            this.cboNhomNV.Name = "cboNhomNV";
            this.cboNhomNV.Size = new System.Drawing.Size(146, 21);
            this.cboNhomNV.TabIndex = 12;
            this.cboNhomNV.SelectionChangeCommitted += new System.EventHandler(this.cboNhomNV_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm nhóm";
            // 
            // cboTimkiemNhóm
            // 
            this.cboTimkiemNhóm.FormattingEnabled = true;
            this.cboTimkiemNhóm.Location = new System.Drawing.Point(562, 58);
            this.cboTimkiemNhóm.Name = "cboTimkiemNhóm";
            this.cboTimkiemNhóm.Size = new System.Drawing.Size(189, 21);
            this.cboTimkiemNhóm.TabIndex = 10;
            this.cboTimkiemNhóm.SelectionChangeCommitted += new System.EventHandler(this.cboTimkiemNhóm_SelectionChangeCommitted);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(120, 93);
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
            this.label7.Location = new System.Drawing.Point(189, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(192, 58);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(140, 21);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(12, 56);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(138, 21);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày làm việc";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ca làm việc";
            // 
            // cboCaLamViec
            // 
            this.cboCaLamViec.FormattingEnabled = true;
            this.cboCaLamViec.Location = new System.Drawing.Point(31, 46);
            this.cboCaLamViec.Name = "cboCaLamViec";
            this.cboCaLamViec.Size = new System.Drawing.Size(189, 21);
            this.cboCaLamViec.TabIndex = 16;
            // 
            // btnThemPhanCong
            // 
            this.btnThemPhanCong.Location = new System.Drawing.Point(304, 224);
            this.btnThemPhanCong.Name = "btnThemPhanCong";
            this.btnThemPhanCong.Size = new System.Drawing.Size(64, 23);
            this.btnThemPhanCong.TabIndex = 15;
            this.btnThemPhanCong.Text = ">>";
            this.btnThemPhanCong.UseVisualStyleBackColor = true;
            this.btnThemPhanCong.Click += new System.EventHandler(this.btnThemPhanCong_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridView2);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(252, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(610, 302);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Bảng phân công công việc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(606, 205);
            this.dataGridView2.TabIndex = 6;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnLuong);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.dateTimePicker1);
            this.groupControl4.Controls.Add(this.cboCaLamViec);
            this.groupControl4.Controls.Add(this.label5);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(2, 22);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(606, 73);
            this.groupControl4.TabIndex = 5;
            // 
            // btnLuong
            // 
            this.btnLuong.Location = new System.Drawing.Point(491, 44);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(66, 23);
            this.btnLuong.TabIndex = 15;
            this.btnLuong.Text = "Tính lương";
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 64);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(298, 302);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Nhân viên";
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(538, 93);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(148, 39);
            this.btnHopDong.TabIndex = 15;
            this.btnHopDong.Text = "In Hợp Đồng ";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 510);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnThemPhanCong);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTimkiemNhóm;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhomNV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCaLamViec;
        private System.Windows.Forms.Button btnThemPhanCong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Button btnLuong;
        private DevExpress.XtraEditors.SimpleButton btnHopDong;
    }
}