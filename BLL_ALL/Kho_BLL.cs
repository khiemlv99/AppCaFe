using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_ALL
{
    public class Kho_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public void getDataNguyenLieu(DataGridView data)
        {
            var nl = from n in qlcf.KhoNguyenLieus select n;
            data.DataSource = nl;
        }

        public IQueryable<KhoNguyenLieu> getDataNguyenLieuTheoNgay(string thang,string nam)
        {
            var nl = from n in qlcf.KhoNguyenLieus where (n.NgayNhap.Value.Month.ToString() == thang && n.NgayNhap.Value.Year.ToString() == nam) select n;

            return nl;
        }
        public void loadCboBox(ComboBox cbo)
        {
            var nl = from n in qlcf.KhoNguyenLieus select n;
            cbo.DataSource = nl;
            cbo.DisplayMember = "TenNguyenLieu";
            cbo.ValueMember="MaNguyenLieu";
        }

        public void timkiemtheomanguyenlieu(string manl, DataGridView data)
        {
            var nl = from n in qlcf.KhoNguyenLieus where n.MaNguyenLieu==manl select n;
            data.DataSource = nl;
        }
        public bool kiemtrakhoachinh(string manl)
        {
            KhoNguyenLieu kho = qlcf.KhoNguyenLieus.Where(t => t.MaNguyenLieu == manl).FirstOrDefault();
            if(kho==null)
            {
                return true;
            }
            return false;
        }

        public void Themnguyenlieu(string manl,string ten,string soluong,string dongia,string dvt,DateTime ngaynhap)
        {
            KhoNguyenLieu kho = new KhoNguyenLieu();
            kho.MaNguyenLieu = manl;
            kho.TenNguyenLieu = ten;
            kho.SoLuong = int.Parse(soluong);
            kho.DVT = dvt;
            
            kho.DonGia = Convert.ToDecimal(dongia);
            kho.NgayNhap = ngaynhap;

            qlcf.KhoNguyenLieus.InsertOnSubmit(kho);
            qlcf.SubmitChanges();
        }

        public void CapNhatnguyenlieu(string manl, string ten, string soluong, string dongia, string dvt, DateTime ngaynhap)
        {
            KhoNguyenLieu kho = qlcf.KhoNguyenLieus.Where(t => t.MaNguyenLieu == manl).FirstOrDefault();
            kho.TenNguyenLieu = ten;
            kho.SoLuong = int.Parse(soluong);
            kho.DVT = dvt;
            kho.DonGia = Convert.ToDecimal(dongia);
            kho.NgayNhap = ngaynhap;
            qlcf.SubmitChanges();
        }

        public void Xoanguyenlieu(string manl)
        {
            KhoNguyenLieu kho = qlcf.KhoNguyenLieus.Where(t => t.MaNguyenLieu == manl).FirstOrDefault();
            qlcf.KhoNguyenLieus.DeleteOnSubmit(kho);
            qlcf.SubmitChanges();
        }
        public void Xoaallnhomnguyenlieu(string manl)
        {
            var kho = qlcf.NhomNguyenLieus.Where(t => t.MaNguyenLieu == manl).ToList();
            foreach(var k in kho)
            {
                qlcf.NhomNguyenLieus.DeleteOnSubmit(k);
            }
            qlcf.SubmitChanges();
        }
        public void loadNhomNguyenLieu(DataGridView data)
        {
            var nhom = from n in qlcf.NhomNguyenLieus select new {n.MaMon,n.MaNguyenLieu,n.SoLuongSuDung };
            data.DataSource = nhom;
        }

        public bool kiemtrakhoachinhnhom(string mamon, string manguyenlieu)
        {
            NhomNguyenLieu nh = qlcf.NhomNguyenLieus.Where(t => t.MaNguyenLieu == manguyenlieu && t.MaMon==mamon).FirstOrDefault();
            if (nh == null)
            {
                return true;
            }
            return false;
        }

        public void ThemNhomNguyenLieu(string mamon,string manguyenlieu,string soluong)
        {
            NhomNguyenLieu nhom = new NhomNguyenLieu();
            nhom.MaMon = mamon;
            nhom.MaNguyenLieu = manguyenlieu;
            nhom.SoLuongSuDung = int.Parse(soluong);

            qlcf.NhomNguyenLieus.InsertOnSubmit(nhom);
            qlcf.SubmitChanges();
        }

        public void XoaNhomNguyenLieu(string mamon, string manguyenlieu)
        {
            NhomNguyenLieu nh = qlcf.NhomNguyenLieus.Where(t => t.MaNguyenLieu == manguyenlieu && t.MaMon == mamon).FirstOrDefault();
            qlcf.NhomNguyenLieus.DeleteOnSubmit(nh);
            qlcf.SubmitChanges();
        }

        public void CapNhatNhomNguyenLieu(string manguyenlieu,string mamon,string soluong)
        {
           
                NhomNguyenLieu nh = qlcf.NhomNguyenLieus.Where(t => t.MaNguyenLieu == manguyenlieu && t.MaMon == mamon).FirstOrDefault();
                nh.SoLuongSuDung = int.Parse(soluong);
                qlcf.SubmitChanges();
            
        }

        public void loadDatatheoCbo(string manhom,DataGridView data)
        {
            var nhom = from n in qlcf.NhomNguyenLieus where(n.MaMon==manhom) select new { n.MaMon, n.MaNguyenLieu, n.SoLuongSuDung };
            data.DataSource = nhom;
        }
        public void loadCboBoxNhom(ComboBox cbo)
        {
            var nl = from n in qlcf.Menus select n;
            cbo.DataSource = nl;
            cbo.DisplayMember = "TenMon";
            cbo.ValueMember = "MaMon";
        }

    }
}
