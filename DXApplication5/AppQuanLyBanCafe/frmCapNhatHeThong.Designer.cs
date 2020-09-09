namespace AppQuanLyBanCafe
{
    partial class frmCapNhatHeThong
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboServername = new System.Windows.Forms.ComboBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(166, 123);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(44, 123);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboServername
            // 
            this.cboServername.FormattingEnabled = true;
            this.cboServername.Location = new System.Drawing.Point(120, 31);
            this.cboServername.Name = "cboServername";
            this.cboServername.Size = new System.Drawing.Size(121, 21);
            this.cboServername.TabIndex = 19;
            this.cboServername.DropDown += new System.EventHandler(this.cboServername_DropDown);
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(120, 77);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(121, 21);
            this.cboDatabase.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Database";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(41, 39);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(64, 13);
            this.Username.TabIndex = 14;
            this.Username.Text = "Servername";
            // 
            // frmCapNhatHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cboServername);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Username);
            this.Name = "frmCapNhatHeThong";
            this.Text = "frmCapNhatHeThong";
            this.Load += new System.EventHandler(this.frmCapNhatHeThong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboServername;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Username;
    }
}