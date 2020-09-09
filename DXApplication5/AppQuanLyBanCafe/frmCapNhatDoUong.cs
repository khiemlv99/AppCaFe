using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ALL;

namespace AppQuanLyBanCafe
{
    public partial class frmCapNhatDoUong : Form
    {
        ThucDon_BLL td = new ThucDon_BLL();
        frmThucDon frmOut;
        public frmCapNhatDoUong(frmThucDon frmIn)
        {
            InitializeComponent();
            frmOut = frmIn;
        }

        private void frmCapNhatDoUong_Load(object sender, EventArgs e)
        {
            loadDoUong();
        }

        public void loadDoUong()
        {
            txtMamonup.Text = thucDon.mamon;
            txtTenMonUp.Text = thucDon.tenmon;
            txtGiaUp.Text = thucDon.Gia.ToString();
            txtDVTUp.Text = thucDon.DVT;
            picHinhAnhUp.Image = thucDon.Hinhanh;
           
        }

        private void btnChonHinhUp_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*gif)|*.jpg;*png;*gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                //picHinhAnh.Image = Image.FromFile(opf.FileName);
                picHinhAnhUp.Image = new Bitmap(opf.FileName);
            }
        }

        private void btnLuuThucDonUp_Click(object sender, EventArgs e)
        {
            try
            {
                if(kiemtrachuoi(txtGiaUp.Text))
                {
                    double gia = double.Parse(txtGiaUp.Text.ToString());
                    td.capNhatDoUong(txtMamonup.Text.ToString(), txtTenMonUp.Text.ToString(), gia, txtDVTUp.Text, picHinhAnhUp);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Chỉ được nhập số!");
                }
               
            }
            catch
            {
                MessageBox.Show("Không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private bool kiemtrachuoi(string str)
        {
            foreach (char i in str)
            {
                if (!char.IsNumber(i))
                    return false;
            }
            return true;
        }
    }

}
