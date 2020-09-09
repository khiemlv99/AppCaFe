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
    public partial class frmThongKeDoanhThu : Form
    {
        HoaDon_BLL ql = new HoaDon_BLL();
        public frmThongKeDoanhThu()
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
            ql.getHoaDon(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = ql.getHoaDonTheoTime(cbbThang.Text, cbbNam.Text);
        }
        ExcelExport excel = new ExcelExport();
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            List<HoaDon> listkhoa = new List<HoaDon>();
            double tong = 0;
            int stt = 1;
            foreach (HoaDon kh in ql.getHoaDonTheoTimeDoanhthu(cbbThang.Text, cbbNam.Text))
            {
                HoaDon k = new HoaDon();
                k.MaGiamGia = kh.MaGiamGia;
                k.NgayXuat = kh.NgayXuat;              
                k.TongTien = kh.TongTien;
                k.STT = stt.ToString();
                tong += (double)kh.TongTien;
                listkhoa.Add(k);
                stt++;
            }


            string path = string.Empty;
            excel.ExportDoanhthu(listkhoa, ref path, false,tong);
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
