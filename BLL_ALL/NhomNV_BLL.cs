using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_ALL
{
    public class NhomNV_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public void getDataNhomNhanVien(DataGridView data)
        {
            var Nhom = from n in qlcf.NhomNhanViens select new { n.MaNhomNV, n.TenNhomNV };
            data.DataSource = Nhom;
        }
        public bool Kiemtrakhoachinh(string manhomnv)
        {
            NhomNhanVien mh = qlcf.NhomNhanViens.Where(t => t.MaNhomNV == manhomnv).FirstOrDefault();
            if (mh == null)
            {
                return true;
            }
            return false;
        }

        public void ThemNhom(string manhomnv, string tennhomnv)
        {
            NhomNhanVien nv = new NhomNhanVien();
            nv.MaNhomNV = manhomnv;
            nv.TenNhomNV = tennhomnv;
            qlcf.NhomNhanViens.InsertOnSubmit(nv);

            foreach (ManHinh mh in qlcf.ManHinhs)
            {
                PhanQuyen phanquyen = new PhanQuyen();
                phanquyen.MaManHinh = mh.MaManHinh;
                phanquyen.MaNhomNV = manhomnv;
                phanquyen.CoQuyen = true;
                qlcf.PhanQuyens.InsertOnSubmit(phanquyen);
            }


            qlcf.SubmitChanges();
        }

        public void CapNhatNhom(string manhomnv, string tennhomnv)
        {
            NhomNhanVien mh = qlcf.NhomNhanViens.Where(t => t.MaNhomNV == manhomnv).FirstOrDefault();
            mh.TenNhomNV = tennhomnv;
            qlcf.SubmitChanges();
        }

        public void XoaNhom(string manhomnv)
        {
            NhomNhanVien mh = qlcf.NhomNhanViens.Where(t => t.MaNhomNV == manhomnv).FirstOrDefault();
           
            List<PhanQuyen> lst = new List<PhanQuyen>();
            foreach (PhanQuyen pq in qlcf.PhanQuyens)
            {
                if (pq.MaNhomNV == manhomnv)
                {
                    lst.Add(pq);
                }

            }
            qlcf.PhanQuyens.DeleteAllOnSubmit(lst);
           
            qlcf.NhomNhanViens.DeleteOnSubmit(mh);
            qlcf.SubmitChanges();
        }

        public void loadcbo(ComboBox cbo)
        {
            var Nhom = from n in qlcf.NhomNhanViens select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaNhomNV";
            cbo.DisplayMember = "TenNhomNV";
        }

        public void LoaddatagridTheoCboBox(string ma, DataGridView data)
        {
            var Nhom = from n in qlcf.NhomNhanViens where (n.MaNhomNV == ma) select new { n.MaNhomNV, n.TenNhomNV };
            data.DataSource = Nhom;
        }
    }
}
