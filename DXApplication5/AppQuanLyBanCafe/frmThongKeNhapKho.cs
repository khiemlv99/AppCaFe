using BLL_ALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyBanCafe
{
    public partial class frmThongKeNhapKho : Form
    {
        public frmThongKeNhapKho()
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
        Kho_BLL kho = new Kho_BLL();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();

            //if (cbo.Khoa_BLL() == null)
            //{
            //    MessageBox.Show("Khong co du lieu");
            //    return;
            //}

            List<KhoNguyenLieu> listkhoa = new List<KhoNguyenLieu>();
            int stt = 1;
            foreach (KhoNguyenLieu kh in kho.getDataNguyenLieuTheoNgay(cbbThang.Text, cbbNam.Text))
            {
                KhoNguyenLieu k = new KhoNguyenLieu();
                k.MaNguyenLieu = kh.MaNguyenLieu;
                k.NgayNhap = kh.NgayNhap;
                k.SoLuong = kh.SoLuong;
                k.TenNguyenLieu = kh.TenNguyenLieu;
                k.DonGia = kh.DonGia;
                k.STT = stt.ToString();
                k.DVT = kh.DVT;

                listkhoa.Add(k);
                stt++;
            }
         

            string path = string.Empty;
            excel.ExportKho(listkhoa, ref path, false);
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
