using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ALL
{
    public class ThongTinHoaDon
    {
        public static String tenNhanVien, NgayXuat, tongTien, giamgia, tienkhachdua, tientralai;

        public static String Giamgia
        {
            get { return ThongTinHoaDon.giamgia; }
            set { ThongTinHoaDon.giamgia = value; }
        }

        public static String NgayXuat1
        {
            get { return ThongTinHoaDon.NgayXuat; }
            set { ThongTinHoaDon.NgayXuat = value; }
        }

        public static String Tientralai
        {
            get { return ThongTinHoaDon.tientralai; }
            set { ThongTinHoaDon.tientralai = value; }
        }

        public static String Tienkhachdua
        {
            get { return ThongTinHoaDon.tienkhachdua; }
            set { ThongTinHoaDon.tienkhachdua = value; }
        }

        public static String TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }


        public static String TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        public static List<SanPhamTrongGioHang> sanhams;

        public static List<SanPhamTrongGioHang> Sanhams
        {
            get { return sanhams; }
            set { sanhams = value; }
        }
    }
}
