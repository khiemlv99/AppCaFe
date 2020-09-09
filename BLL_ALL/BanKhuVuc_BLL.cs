using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL_ALL
{
    public class BanKhuVuc_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public BanKhuVuc_BLL() { }

        public List<Ban> getAllTableforArea( string makhu)
        {
            List<Ban> banlist = (from k in qlcf.Bans where k.MaKhuVuc.Equals(makhu) select k ).ToList();
            return banlist;
        }

        public List<KhuVuc> getAllKhuVuc()
        {
            List<KhuVuc> khulist = (from kh in qlcf.KhuVucs select kh).ToList();
            return khulist;
        }

        public void CapNhatLaiTrangThaiBan(int maban)
        {
            
            var bans = (from b in qlcf.Bans where b.MaBan == maban select b).ToList() ;
            foreach(Ban b in bans)
            {
                if(KiemTraSoLuongDaDat(maban))
                {
                    b.TrangThai = 1;
                }
            }            
            qlcf.SubmitChanges();
        }
        public void CapNhatLaiTrangThaiBanTrong(int maban)
        {
            var bans = (from b in qlcf.Bans where b.MaBan == maban select b).ToList();
            foreach (Ban b in bans)
            {
                if (KiemTraSoLuongDaDat(maban))
                {
                    b.TrangThai = 0;
                }
            }
            qlcf.SubmitChanges();
        }

        public void CapNhatTrong(int maban)
        {
            Ban b = qlcf.Bans.Where(t => t.MaBan == maban).FirstOrDefault();
            if(b !=null)
            {
                b.TrangThai = 0;
            }
            qlcf.SubmitChanges();
        }

        public void CapNhatLaiTrangthaiBanDatTruoc(int maban)
        {
            Ban bans = qlcf.Bans.Where(t => t.MaBan == maban).FirstOrDefault();
            if (bans.TrangThai == 0)
            {
                bans.TrangThai = 2;
            }
            qlcf.SubmitChanges();
        }

        public bool checkTrangThaiDatBan(int maban)
        {
            Ban bans = qlcf.Bans.Where(t => t.MaBan == maban).FirstOrDefault();
            if (bans.TrangThai == 2)
                return true;
            return false;
        }

        public bool KiemTraSoLuongDaDat(int maban)
        {
            try
            {
                DanhSachMonGoi ds = qlcf.DanhSachMonGois.Where(t => t.MaBan == maban).FirstOrDefault();
                if (ds.SoLuong != 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Chưa có sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
           
        }

        public void chuyenBan(int mabanhientai,int mabanchuyen)
        {

            List<DanhSachMonGoi> banhientai = qlcf.DanhSachMonGois.Where(t => t.MaBan == mabanhientai).ToList();            
     
            foreach(DanhSachMonGoi ban in banhientai)
            {
                DanhSachMonGoi banchuyen = new DanhSachMonGoi();
                banchuyen.MaBan = mabanchuyen;
                banchuyen.MaMon = ban.MaMon;
                banchuyen.SoLuong = ban.SoLuong;
                qlcf.DanhSachMonGois.InsertOnSubmit(banchuyen);
            }

            Ban trangthaibanhientai = qlcf.Bans.Where(t => t.MaBan == mabanhientai).FirstOrDefault();
            trangthaibanhientai.TrangThai = 0;

            Ban trangthaibanchuyen = qlcf.Bans.Where(t => t.MaBan == mabanchuyen).FirstOrDefault();
            trangthaibanchuyen.TrangThai = 1;

            qlcf.DanhSachMonGois.DeleteAllOnSubmit(banhientai);

            qlcf.SubmitChanges();
        }

        public void gopBan(int mabanhientai, int mabangop)
        {

            List<DanhSachMonGoi> bangop = qlcf.DanhSachMonGois.Where(t => t.MaBan == mabangop).ToList();


            foreach (DanhSachMonGoi ban in bangop)
            {
                if(kiemtramontontai(ban.MaMon,mabanhientai))
                {
                DanhSachMonGoi banhientai = new DanhSachMonGoi();
                banhientai.MaBan = mabanhientai;
                banhientai.MaMon = ban.MaMon;
                banhientai.SoLuong = ban.SoLuong;
                qlcf.DanhSachMonGois.InsertOnSubmit(banhientai);
                }
                else
                {
                    DanhSachMonGoi b = qlcf.DanhSachMonGois.Where(t => t.MaBan == mabanhientai && t.MaMon==ban.MaMon).FirstOrDefault();
                    b.SoLuong += ban.SoLuong;
                }
            }

         
            Ban trangthaibangop = qlcf.Bans.Where(t => t.MaBan == mabangop).FirstOrDefault();
            trangthaibangop.TrangThai = 0;

            qlcf.DanhSachMonGois.DeleteAllOnSubmit(bangop);

            qlcf.SubmitChanges();
        }
        public bool kiemtratrangthaichuyenban(int ma)
        {
            DanhSachMonGoi ban = qlcf.DanhSachMonGois.Where(t => t.MaBan == ma).FirstOrDefault();
            if (ban != null)
                return true;
            return false;
        }

        public bool kiemtramontontai(string mamon,int maban)
        {
            DanhSachMonGoi ban = qlcf.DanhSachMonGois.Where(t => t.MaMon == mamon && t.MaBan==maban).FirstOrDefault();
            if (ban == null)
                return true;
            return false;
        }

        public bool kiemTraTonTaiBan(int maban)
        {
            var mg = qlcf.DanhSachMonGois.Where(t => t.MaBan == maban).ToList();
            if(mg.Count !=0)
            {
                return true;
            }
            return false;
        }

        public int getAllDsMonGoi(int maban)
        {
            var mons = (from m in qlcf.DanhSachMonGois where m.MaBan == maban select m).ToList();
            return mons.Count;
        }
    }
}
