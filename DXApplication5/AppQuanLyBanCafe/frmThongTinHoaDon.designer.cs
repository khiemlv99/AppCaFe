namespace AppQuanLyBanCafe
{
    partial class frmThongTinHoaDon
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMaGiamGia = new System.Windows.Forms.ComboBox();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenNhanvien = new System.Windows.Forms.Label();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgHoadontamtinh = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadontamtinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.cboMaGiamGia);
            this.panelControl1.Controls.Add(this.txtTienThua);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.txtTienKhach);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.btnXuatHoaDon);
            this.panelControl1.Controls.Add(this.lblTenNhanvien);
            this.panelControl1.Controls.Add(this.lblNgayMua);
            this.panelControl1.Controls.Add(this.lblMaBan);
            this.panelControl1.Controls.Add(this.lblTongTien);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.dtgHoadontamtinh);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(514, 554);
            this.panelControl1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Voucher:";
            // 
            // cboMaGiamGia
            // 
            this.cboMaGiamGia.FormattingEnabled = true;
            this.cboMaGiamGia.Items.AddRange(new object[] {
            "None"});
            this.cboMaGiamGia.Location = new System.Drawing.Point(311, 443);
            this.cboMaGiamGia.Name = "cboMaGiamGia";
            this.cboMaGiamGia.Size = new System.Drawing.Size(102, 21);
            this.cboMaGiamGia.TabIndex = 16;
            this.cboMaGiamGia.SelectedIndexChanged += new System.EventHandler(this.cboMaGiamGia_SelectedIndexChanged);
            this.cboMaGiamGia.SelectedValueChanged += new System.EventHandler(this.cboMaGiamGia_SelectedValueChanged);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Location = new System.Drawing.Point(103, 513);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(121, 21);
            this.txtTienThua.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiền trả lại:";
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.Location = new System.Drawing.Point(103, 478);
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(121, 21);
            this.txtTienKhach.TabIndex = 13;
            this.txtTienKhach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTienKhach_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền khách đưa:";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(428, 431);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(81, 43);
            this.btnXuatHoaDon.TabIndex = 11;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn\r\n";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // lblTenNhanvien
            // 
            this.lblTenNhanvien.AutoSize = true;
            this.lblTenNhanvien.Location = new System.Drawing.Point(305, 163);
            this.lblTenNhanvien.Name = "lblTenNhanvien";
            this.lblTenNhanvien.Size = new System.Drawing.Size(35, 13);
            this.lblTenNhanvien.TabIndex = 10;
            this.lblTenNhanvien.Text = "label9";
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Location = new System.Drawing.Point(305, 116);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(35, 13);
            this.lblNgayMua.TabIndex = 9;
            this.lblNgayMua.Text = "label8";
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Location = new System.Drawing.Point(305, 69);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(35, 13);
            this.lblMaBan.TabIndex = 8;
            this.lblMaBan.Text = "label7";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(108, 441);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(34, 16);
            this.lblTongTien.TabIndex = 7;
            this.lblTongTien.Text = "Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền:";
            // 
            // dtgHoadontamtinh
            // 
            this.dtgHoadontamtinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHoadontamtinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoadontamtinh.Location = new System.Drawing.Point(13, 239);
            this.dtgHoadontamtinh.Name = "dtgHoadontamtinh";
            this.dtgHoadontamtinh.Size = new System.Drawing.Size(489, 183);
            this.dtgHoadontamtinh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách món đã gọi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã bàn:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN TẠM TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 554);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThongTinHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn tạm tính";
            this.Load += new System.EventHandler(this.frmThongTinHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadontamtinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenNhanvien;
        private System.Windows.Forms.Label lblNgayMua;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgHoadontamtinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnXuatHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMaGiamGia;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.TextBox txtTienKhach;

    }
}