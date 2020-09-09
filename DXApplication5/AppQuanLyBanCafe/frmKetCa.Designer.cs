namespace AppQuanLyBanCafe
{
    partial class frmKetCa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTienHeThong = new System.Windows.Forms.TextBox();
            this.txtTongTienThucTe = new System.Windows.Forms.TextBox();
            this.btnXuatBaoCao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "KẾT CA CUỐI NGÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TỔNG TIỀN TRÊN HỆ THỐNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = " TỔNG TIỀN THỰC TẾ";
            // 
            // txtTongTienHeThong
            // 
            this.txtTongTienHeThong.Enabled = false;
            this.txtTongTienHeThong.Location = new System.Drawing.Point(210, 311);
            this.txtTongTienHeThong.Name = "txtTongTienHeThong";
            this.txtTongTienHeThong.Size = new System.Drawing.Size(159, 20);
            this.txtTongTienHeThong.TabIndex = 5;
            // 
            // txtTongTienThucTe
            // 
            this.txtTongTienThucTe.Location = new System.Drawing.Point(210, 339);
            this.txtTongTienThucTe.Name = "txtTongTienThucTe";
            this.txtTongTienThucTe.Size = new System.Drawing.Size(159, 20);
            this.txtTongTienThucTe.TabIndex = 6;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(122, 365);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(171, 53);
            this.btnXuatBaoCao.TabIndex = 7;
            this.btnXuatBaoCao.Text = "XUẤT BÁO CÁO CUỐI NGÀY";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // frmKetCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 430);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.txtTongTienThucTe);
            this.Controls.Add(this.txtTongTienHeThong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKetCa";
            this.Text = "frmKetCa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTienHeThong;
        private System.Windows.Forms.TextBox txtTongTienThucTe;
        private DevExpress.XtraEditors.SimpleButton btnXuatBaoCao;
    }
}