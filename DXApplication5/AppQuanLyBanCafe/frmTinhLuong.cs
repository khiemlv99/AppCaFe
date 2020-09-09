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
    public partial class frmTinhLuong : Form
    {
        public frmTinhLuong()
        {
            InitializeComponent();
            for (int i = 2017; i <= 2030; i++)
            {
                cbbNam.Properties.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Properties.Items.Add(i);
            }
        }
        NhanVien_BLL nv = new NhanVien_BLL();
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();

            //if (cbo.Khoa_BLL() == null)
            //{
            //    MessageBox.Show("Khong co du lieu");
            //    return;
            //}

            List<thongkeluong> listkhoa = new List<thongkeluong>();
            listkhoa = nv.getLuongNhanVien(cbbThang.Text, cbbNam.Text);

            string path = string.Empty;
            excel.ExportLuong(listkhoa, ref path, false);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) &&
            MessageBox.Show("Bạn có muốn mở file không?", "Thông tin",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton
            .Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
