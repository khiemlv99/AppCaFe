using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_ALL
{
    public class NhanVien_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public void getNhanVien(DataGridView data)
        {
            var Nhom = from n in qlcf.NhanViens select new { n.MaNhanVien, n.TenNhanVien, n.MaNhomNV };
            data.DataSource = Nhom;
        }
        
        public List<thongkeluong> getLuongNhanVien(string thang ,string nam)
        {
            var luong = from n in qlcf.BangPhanCongCVs                      
                        join m in qlcf.NhanViens on n.MaNhanVien equals m.MaNhanVien 
                        join k in qlcf.CaLamViecs on n.CaLamViec equals k.CaLamViec1 
                        where(n.NgayLam.Month.ToString()==thang && n.NgayLam.Year.ToString()==nam) select new {n.NgayLam,n.MaNhanVien,k.GioLamViec,m.TenNhanVien };

            List<thongkeluong> lst = new List<thongkeluong>();
            int stt = 1;
            foreach (var b in luong)
            {
                thongkeluong tk= new thongkeluong();
                tk.NgayLam1 = b.NgayLam.ToString();
                tk.TenNV1 = b.TenNhanVien;
                tk.Stt1 = stt;
                tk.GioLamViec1 = b.GioLamViec;
                tk.MaNV1 = b.MaNhanVien;

                lst.Add(tk);
                stt++;
            }
            return lst;
        }

        public void getBangPhanCong(DataGridView data)
        {
            var Nhom = from n in qlcf.BangPhanCongCVs join b in qlcf.NhanViens on n.MaNhanVien equals b.MaNhanVien select new {b.TenNhanVien,n.NgayLam,n.CaLamViec};
            data.DataSource = Nhom;
        }
        public bool Kiemtrakhoachinh(string manv)
        {
            NhanVien mh = qlcf.NhanViens.Where(t => t.MaNhanVien == manv).FirstOrDefault();
            if (mh == null)
            {
                return true;
            }
            return false;
        }

        public void ThemNV(string manv, string tennv,string manhomnv)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = manv;
            nv.TenNhanVien = tennv;
            nv.MaNhomNV = manhomnv;
            qlcf.NhanViens.InsertOnSubmit(nv);
            qlcf.SubmitChanges();
        }

        public void CapNhatNV(string manv, string tennv, string manhomnv)
        {
            NhanVien mh = qlcf.NhanViens.Where(t => t.MaNhanVien == manv).FirstOrDefault();
            mh.TenNhanVien = tennv;
            mh.MaNhomNV = manhomnv;
            qlcf.SubmitChanges();
        }

        public void XoaNV(string manv)
        {
            NhanVien mh = qlcf.NhanViens.Where(t => t.MaNhanVien == manv).FirstOrDefault();
            qlcf.NhanViens.DeleteOnSubmit(mh);
            qlcf.SubmitChanges();
        }

        public void loadcbo(ComboBox cbo)
        {
            var Nhom = from n in qlcf.NhanViens select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaNhanVien";
            cbo.DisplayMember = "TenNhanVien";
        }
        public void loadcboNhom(ComboBox cbo)
        {
            var Nhom = from n in qlcf.NhomNhanViens select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaNhomNV";
            cbo.DisplayMember = "TenNhomNV";
        }
        public void loadcboCalam(ComboBox cbo)
        {
            var ca = from n in qlcf.CaLamViecs select n;
            cbo.DataSource = ca;
            cbo.ValueMember = "CaLamViec1";
            cbo.DisplayMember = "CaLamViec1";
        }

        
        public void LoaddatagridTheoCboBox(string ma, DataGridView data)
        {
            var Nhom = from n in qlcf.NhanViens where (n.MaNhanVien == ma) select new { n.MaNhanVien, n.TenNhanVien, n.MaNhomNV };
            data.DataSource = Nhom;
        }
        public void LoaddatagridTheodatetimepicker(DateTime ngay, DataGridView data)
        {
            var Nhom = from n in qlcf.BangPhanCongCVs where (n.NgayLam == ngay) join b in qlcf.NhanViens on n.MaNhanVien equals b.MaNhanVien select new { b.TenNhanVien, n.NgayLam, n.CaLamViec };
            data.DataSource = Nhom;
        }

        public void ThemBanPhanCong(string ca,string manhanvien,DateTime ngay)
        {
            BangPhanCongCV cv = new BangPhanCongCV();
            cv.CaLamViec = int.Parse(ca);
            cv.MaNhanVien = manhanvien;
            cv.NgayLam = ngay;
            qlcf.BangPhanCongCVs.InsertOnSubmit(cv);
            qlcf.SubmitChanges();
        }

        public bool Kiemtrakhoachinhcv(string ca, string manhanvien, DateTime ngay)
        {
            BangPhanCongCV mh = qlcf.BangPhanCongCVs.Where(t => t.MaNhanVien == manhanvien && t.CaLamViec==int.Parse(ca) && t.NgayLam==ngay).FirstOrDefault();
            if (mh == null)
            {
                return true;
            }
            return false;
        }



    }
}
