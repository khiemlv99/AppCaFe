using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_ALL
{
    
    public class HoaDon_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
           
        public int Ketca()
        {
            return qlcf.DanhSachMonGois.Count();
        }
        public int demhoadon()
        {
            int hd = qlcf.HoaDons.Where(n=> n.NgayXuat.Value.Day == DateTime.Now.Day && n.NgayXuat.Value.Month == DateTime.Now.Month && n.NgayXuat.Value.Year == DateTime.Now.Year).Count();
            return hd;
        }         
        public void getHoaDon(DataGridView data)
        {
            var hd = from n in qlcf.HoaDons select new{n.MaHoaDon,n.TongTien,n.MaGiamGia,n.NgayXuat};
            data.DataSource = hd;
        }

        public IQueryable getHoaDonTheoTime(string thang, string nam)
        {
            var hd = from n in qlcf.HoaDons where (n.NgayXuat.Value.Day.ToString() == thang && n.NgayXuat.Value.Year.ToString() == nam) select new { n.MaHoaDon, n.TongTien, n.MaGiamGia, n.NgayXuat };
            return hd;
        }

        public List<HoaDon> getHoaDonTheoHomNay()
        {
            var hd = from n in qlcf.HoaDons where (n.NgayXuat.Value.Day == DateTime.Now.Day && n.NgayXuat.Value.Month == DateTime.Now.Month && n.NgayXuat.Value.Year == DateTime.Now.Year) select n;

            int stt = 1;
            List<HoaDon> listkhoa = new List<HoaDon>();
            foreach (HoaDon kh in hd)
            {
                HoaDon k = new HoaDon();
                k.MaGiamGia = kh.MaGiamGia;
                k.NgayXuat = kh.NgayXuat;
                k.TongTien = kh.TongTien;
                k.STT = stt.ToString();

                listkhoa.Add(k);
                stt++;
            }
            return listkhoa;
        }
        public IQueryable getHoaDonTheoTimeDoanhthu(string thang, string nam)
        {
            var hd = from n in qlcf.HoaDons where (n.NgayXuat.Value.Day.ToString() == thang && n.NgayXuat.Value.Year.ToString() == nam) select n;
            return hd;
        }
    }
}
