namespace AppQuanLyBanCafe
{
    partial class frmQuanLyKhu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnKetCa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDatBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnGopBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyenBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTraLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnChonMua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadLai = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl4);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(986, 481);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl4.Location = new System.Drawing.Point(751, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(233, 377);
            this.groupControl4.TabIndex = 12;
            this.groupControl4.Text = "Chi tiết đặt bàn";
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.tabControl);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(172, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(812, 377);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Danh sách bàn";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(2, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(808, 336);
            this.tabControl.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.btnKetCa);
            this.groupControl2.Controls.Add(this.btnXuatHoaDon);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(172, 379);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(812, 100);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Tính tiền";
            // 
            // btnKetCa
            // 
            this.btnKetCa.Location = new System.Drawing.Point(579, 47);
            this.btnKetCa.Name = "btnKetCa";
            this.btnKetCa.Size = new System.Drawing.Size(88, 53);
            this.btnKetCa.TabIndex = 2;
            this.btnKetCa.Text = "Kết ca";
            this.btnKetCa.Click += new System.EventHandler(this.btnKetCa_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(390, 42);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(88, 53);
            this.btnXuatHoaDon.TabIndex = 1;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tổng tiền";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.btnLoadLai);
            this.groupControl1.Controls.Add(this.btnDatBan);
            this.groupControl1.Controls.Add(this.btnGopBan);
            this.groupControl1.Controls.Add(this.btnChuyenBan);
            this.groupControl1.Controls.Add(this.btnTraLai);
            this.groupControl1.Controls.Add(this.btnChonMua);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(170, 477);
            this.groupControl1.TabIndex = 9;
            // 
            // btnDatBan
            // 
            this.btnDatBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDatBan.ImageOptions.SvgImage")));
            this.btnDatBan.Location = new System.Drawing.Point(5, 281);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(158, 40);
            this.btnDatBan.TabIndex = 4;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnGopBan
            // 
            this.btnGopBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGopBan.ImageOptions.SvgImage")));
            this.btnGopBan.Location = new System.Drawing.Point(5, 223);
            this.btnGopBan.Name = "btnGopBan";
            this.btnGopBan.Size = new System.Drawing.Size(158, 40);
            this.btnGopBan.TabIndex = 3;
            this.btnGopBan.Text = "Gộp bàn";
            this.btnGopBan.Click += new System.EventHandler(this.btnGopBan_Click);
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChuyenBan.ImageOptions.SvgImage")));
            this.btnChuyenBan.Location = new System.Drawing.Point(7, 165);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(158, 40);
            this.btnChuyenBan.TabIndex = 2;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // btnTraLai
            // 
            this.btnTraLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTraLai.ImageOptions.SvgImage")));
            this.btnTraLai.Location = new System.Drawing.Point(7, 107);
            this.btnTraLai.Name = "btnTraLai";
            this.btnTraLai.Size = new System.Drawing.Size(158, 40);
            this.btnTraLai.TabIndex = 1;
            this.btnTraLai.Text = "Hủy lệnh";
            this.btnTraLai.Click += new System.EventHandler(this.btnTraLai_Click);
            // 
            // btnChonMua
            // 
            this.btnChonMua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChonMua.ImageOptions.SvgImage")));
            this.btnChonMua.Location = new System.Drawing.Point(7, 49);
            this.btnChonMua.Name = "btnChonMua";
            this.btnChonMua.Size = new System.Drawing.Size(158, 40);
            this.btnChonMua.TabIndex = 0;
            this.btnChonMua.Text = "Chọn mua";
            this.btnChonMua.Click += new System.EventHandler(this.btnChonMua_Click);
            // 
            // btnLoadLai
            // 
            this.btnLoadLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnLoadLai.Location = new System.Drawing.Point(5, 348);
            this.btnLoadLai.Name = "btnLoadLai";
            this.btnLoadLai.Size = new System.Drawing.Size(158, 40);
            this.btnLoadLai.TabIndex = 5;
            this.btnLoadLai.Text = "Load lại";
            this.btnLoadLai.Click += new System.EventHandler(this.btnLoadLai_Click);
            // 
            // frmQuanLyKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 481);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmQuanLyKhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyKhu";
            this.Load += new System.EventHandler(this.frmQuanLyKhu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TabControl tabControl;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXuatHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDatBan;
        private DevExpress.XtraEditors.SimpleButton btnGopBan;
        private DevExpress.XtraEditors.SimpleButton btnChuyenBan;
        private DevExpress.XtraEditors.SimpleButton btnTraLai;
        private DevExpress.XtraEditors.SimpleButton btnChonMua;
        private DevExpress.XtraEditors.SimpleButton btnKetCa;
        private DevExpress.XtraEditors.SimpleButton btnLoadLai;
    }
}