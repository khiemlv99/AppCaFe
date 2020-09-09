using Microsoft.Reporting.WinForms;
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
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report2.rdlc";


            SanPhamTrongGioHangBindingSource.DataSource = BLL_ALL.ThongTinHoaDon.sanhams;
            ReportParameter rp = new ReportParameter("pTongTien", BLL_ALL.ThongTinHoaDon.tongTien);
            ReportParameter rp1 = new ReportParameter("pTienKhachDua", BLL_ALL.ThongTinHoaDon.Tienkhachdua);
            ReportParameter rp2 = new ReportParameter("PNgayXuat", BLL_ALL.ThongTinHoaDon.NgayXuat);
            ReportParameter rp3 = new ReportParameter("pTenNhanVien", BLL_ALL.ThongTinHoaDon.tenNhanVien);
            ReportParameter rp4 = new ReportParameter("pTienThua", BLL_ALL.ThongTinHoaDon.Tientralai);
            //ReportParameter rp5 = new ReportParameter("pGiamGia", BLL_ALL.ThongTinHoaDon.Giamgia);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp3, rp1, rp2, rp,rp4 });

            this.reportViewer1.RefreshReport();
        }
    }
}
