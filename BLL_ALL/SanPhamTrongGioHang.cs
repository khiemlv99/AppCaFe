using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ALL
{
    public class SanPhamTrongGioHang
    {
        public String tenSanPham, soLuong, thanhTien;
        public SanPhamTrongGioHang()
        {
        }

        public SanPhamTrongGioHang(String tenSanPham, String soLuong, String thanhTien)
        {
            this.TenSanPham = tenSanPham;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
        public String ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

        public String SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public String TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
    }
}
