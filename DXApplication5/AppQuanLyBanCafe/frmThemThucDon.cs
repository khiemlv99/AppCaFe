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
using System.IO;

namespace AppQuanLyBanCafe
{
    public partial class frmThemThucDon : Form
    {
        ThucDon_BLL td = new ThucDon_BLL();
        frmThucDon frmOut;
        public frmThemThucDon(frmThucDon frmIn)
        {
            InitializeComponent();
            frmOut = frmIn;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*png;*gif)|*.jpg;*png;*gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                //picHinhAnh.Image = Image.FromFile(opf.FileName);
                picHinhAnh.Image = new Bitmap(opf.FileName);
            }
        }

        private void btnLuuThucDon_Click(object sender, EventArgs e)
        {
            if(kiemtrachuoi(txtGia.Text))
            {
                int gia = int.Parse(txtGia.Text.Trim());
                td.ThemThucDon(txtMaMon.Text.Trim(), txtTenMon.Text.Trim(), gia, txtDonViTinh.Text.Trim(), picHinhAnh);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ được nhập số!");
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
