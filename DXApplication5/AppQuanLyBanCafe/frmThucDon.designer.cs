namespace AppQuanLyBanCafe
{
    partial class frmThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucDon));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdatedoUong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDoUong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDoUong = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgThucDon = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(970, 490);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnUpdatedoUong);
            this.groupControl1.Controls.Add(this.btnXoaDoUong);
            this.groupControl1.Controls.Add(this.btnThemDoUong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 486);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chi tiết thực đơn";
            // 
            // btnUpdatedoUong
            // 
            this.btnUpdatedoUong.Location = new System.Drawing.Point(22, 200);
            this.btnUpdatedoUong.Name = "btnUpdatedoUong";
            this.btnUpdatedoUong.Size = new System.Drawing.Size(212, 31);
            this.btnUpdatedoUong.TabIndex = 2;
            this.btnUpdatedoUong.Text = "Cập nhật đồ uống";
            this.btnUpdatedoUong.Click += new System.EventHandler(this.btnUpdatedoUong_Click);
            // 
            // btnXoaDoUong
            // 
            this.btnXoaDoUong.Location = new System.Drawing.Point(22, 142);
            this.btnXoaDoUong.Name = "btnXoaDoUong";
            this.btnXoaDoUong.Size = new System.Drawing.Size(212, 31);
            this.btnXoaDoUong.TabIndex = 1;
            this.btnXoaDoUong.Text = "Xóa đồ uống";
            this.btnXoaDoUong.Click += new System.EventHandler(this.btnXoaDoUong_Click);
            // 
            // btnThemDoUong
            // 
            this.btnThemDoUong.Location = new System.Drawing.Point(22, 85);
            this.btnThemDoUong.Name = "btnThemDoUong";
            this.btnThemDoUong.Size = new System.Drawing.Size(212, 31);
            this.btnThemDoUong.TabIndex = 0;
            this.btnThemDoUong.Text = "Thêm đồ uống";
            this.btnThemDoUong.Click += new System.EventHandler(this.btnThemDoUong_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.dtgThucDon);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(268, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(700, 486);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh sách món";
            // 
            // dtgThucDon
            // 
            this.dtgThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgThucDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.Gia,
            this.DVT,
            this.HinhAnh});
            this.dtgThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgThucDon.GridColor = System.Drawing.Color.Gray;
            this.dtgThucDon.Location = new System.Drawing.Point(2, 37);
            this.dtgThucDon.Name = "dtgThucDon";
            this.dtgThucDon.Size = new System.Drawing.Size(696, 447);
            this.dtgThucDon.TabIndex = 1;
            this.dtgThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgThucDon_CellClick);
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
            this.HinhAnh.HeaderText = "Hình";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HinhAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(970, 490);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmThucDon";
            this.Text = "Thực đơn";
            this.Load += new System.EventHandler(this.frmThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdatedoUong;
        private DevExpress.XtraEditors.SimpleButton btnXoaDoUong;
        private DevExpress.XtraEditors.SimpleButton btnThemDoUong;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dtgThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
    }
}