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
    public partial class frmKetCa : Form
    {
        HoaDon_BLL hoadon = new HoaDon_BLL();
      
        public frmKetCa()
        {
            InitializeComponent();
            dataGridView1.DataSource = hoadon.getHoaDonTheoHomNay();
              double tongtien = 0;
            foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                try
                {                   
                    tongtien+= Double.Parse( item.Cells[3].Value.ToString());
                }
                catch
                {

                }
            }
            txtTongTienHeThong.Text = tongtien.ToString();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }
        ExcelExport excel = new ExcelExport();
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (txtTongTienThucTe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền thực tế", "Thông báo");
                txtTongTienThucTe.Focus();
            }
            else
            {
                List<HoaDon> listkhoa = new List<HoaDon>();
                int stt = 1;
                foreach (HoaDon kh in hoadon.getHoaDonTheoHomNay())
                {
                    HoaDon k = new HoaDon();
                    k.MaGiamGia = kh.MaGiamGia;
                    k.NgayXuat = kh.NgayXuat;
                    k.TongTien = kh.TongTien;
                    k.STT = stt.ToString();

                    listkhoa.Add(k);
                    stt++;
                }


                string path = string.Empty;
                excel.ExportKetca(listkhoa, ref path, false, int.Parse(txtTongTienHeThong.Text), int.Parse(txtTongTienThucTe.Text));
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
}
