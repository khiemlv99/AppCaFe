using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_ALL
{
    public class ManHinh_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public void getDataManHinh(DataGridView data)
        {
            var Nhom = from n in qlcf.ManHinhs select new { n.MaManHinh, n.TenManHinh };
            data.DataSource = Nhom;
        }
        public bool Kiemtrakhoachinh(string mamanhinh)
        {
            ManHinh mh = qlcf.ManHinhs.Where(t => t.MaManHinh == mamanhinh).FirstOrDefault();
            if (mh == null)
            {
                return true;
            }
            return false;
        }

        public void ThemmanHinh(string mamanhinh, string tenmanhinh)
        {
            ManHinh mh = new ManHinh();
            mh.MaManHinh = mamanhinh;
            mh.TenManHinh = tenmanhinh;
            qlcf.ManHinhs.InsertOnSubmit(mh);

            foreach(NhomNhanVien tk in qlcf.NhomNhanViens)
            {
                PhanQuyen phanquyen = new PhanQuyen();
                phanquyen.MaManHinh = mamanhinh;
                phanquyen.MaNhomNV = tk.MaNhomNV;
                phanquyen.CoQuyen = true;
                qlcf.PhanQuyens.InsertOnSubmit(phanquyen);
            }
           
            
            qlcf.SubmitChanges();
        }

        public void CapNhatManHinh(string mamanhinh, string tenmanhinh)
        {
            ManHinh mh = qlcf.ManHinhs.Where(t => t.MaManHinh == mamanhinh).FirstOrDefault();
            mh.TenManHinh = tenmanhinh;

            qlcf.SubmitChanges();
        }

        public void XoaManHinh(string mamanhinh)
        {
            ManHinh mh = qlcf.ManHinhs.Where(t => t.MaManHinh == mamanhinh).FirstOrDefault();
            List<PhanQuyen> lst = new List<PhanQuyen>();
            foreach (PhanQuyen pq in qlcf.PhanQuyens)
            {
                if (pq.MaManHinh == mamanhinh)
                {
                    lst.Add(pq);
                }

            }
            qlcf.PhanQuyens.DeleteAllOnSubmit(lst);
            qlcf.ManHinhs.DeleteOnSubmit(mh);
            qlcf.SubmitChanges();
        }

        public void loadcbo(ComboBox cbo)
        {
            var Nhom = from n in qlcf.ManHinhs select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaManHinh";
            cbo.DisplayMember = "TenManHinh";
        }

        public void LoaddatagridTheoCboBox(string ma, DataGridView data)
        {
            var Nhom = from n in qlcf.ManHinhs where (n.MaManHinh == ma) select new { n.MaManHinh, n.TenManHinh };
            data.DataSource = Nhom;
        }
    }
}
