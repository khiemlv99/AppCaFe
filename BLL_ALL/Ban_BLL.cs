using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_ALL
{
    public class Ban_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();

        public bool kiemtrakhoachinh(string maban)
        {
            Ban ban = qlcf.Bans.Where(t => t.MaBan == int.Parse(maban)).FirstOrDefault();
            if(ban==null)
            {
                return true;
            }
            return false;
        }

        public void loadcboKhu(ComboBox cbo)
        {
            var ban = from b in qlcf.KhuVucs select b;
            cbo.DataSource = ban;
            cbo.DisplayMember = "MaKhuVuc";
            cbo.ValueMember = "MaKhuVuc";
        }
        public int TuDongSinhMaBan()
        {
            return qlcf.Bans.Count() + 1 ;

        }
        public string TuDongSinhTenBan()
        {
            return "Bàn "+ (qlcf.Bans.Count() + 1).ToString();

        }
        public void ThemBan(string maban,string tenban,string trangthai,string makhuvuc)
        {
            Ban ban = new Ban();
            ban.MaBan = int.Parse(maban);
            ban.TenBan = tenban;
            ban.TrangThai = 0;
            ban.MaKhuVuc = makhuvuc;
            qlcf.Bans.InsertOnSubmit(ban);
            qlcf.SubmitChanges();
        }

        public void CapNhatBan(string maban,string tenban,string makhuvuc)
        {
            Ban ban = qlcf.Bans.Where(t => t.MaBan == int.Parse(maban)).FirstOrDefault();
            ban.TenBan = tenban;
            ban.MaKhuVuc = makhuvuc;
            qlcf.SubmitChanges();
        }

        public void XoaBan(string maban)
        {
            Ban ban = qlcf.Bans.Where(t => t.MaBan == int.Parse(maban)).FirstOrDefault();
            qlcf.Bans.DeleteOnSubmit(ban);
            qlcf.SubmitChanges();
        }

        public string KhuVuc(string maban)
        {
            Ban ban = qlcf.Bans.Where(t => t.MaBan == int.Parse(maban)).FirstOrDefault();
            return ban.MaKhuVuc;
        }

        public bool kiemtrakhoachinhkhuvuc(string makhu)
        {
            KhuVuc khu = qlcf.KhuVucs.Where(t => t.MaKhuVuc == makhu).FirstOrDefault();
            if (khu == null)
                return true;
            return false;
        }
        public void Themkhu(string makhu, string tenkhu)
        {
            KhuVuc khu = new KhuVuc();
            khu.MaKhuVuc = makhu;
            khu.TenKhuVuc = tenkhu;

            qlcf.KhuVucs.InsertOnSubmit(khu);
            qlcf.SubmitChanges();
        }

        public void CapNhatKhu(string makhu, string tenkhu)
        {
            KhuVuc khu = qlcf.KhuVucs.Where(t => t.MaKhuVuc == makhu).FirstOrDefault();
            khu.TenKhuVuc = tenkhu;
           
            qlcf.SubmitChanges();
        }

        public void XoaKhu(string makhu)
        {
            KhuVuc khu = qlcf.KhuVucs.Where(t => t.MaKhuVuc == makhu).FirstOrDefault();
            qlcf.KhuVucs.DeleteOnSubmit(khu);
            qlcf.SubmitChanges();
        }

        public void XoaBanTrongKhu(string makhu)
        {
            var ban = qlcf.Bans.Where(t => t.MaKhuVuc == makhu).ToList();

            foreach(Ban b in ban)
            {
                qlcf.Bans.DeleteOnSubmit(b);
            }

           
            qlcf.SubmitChanges();
        }
    }
}
