using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_ALL
{
    public class PhanQuyen_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();

       
        public void GetDataNhomTK(DataGridView data)
        {
            var Nhom = from n in qlcf.NhomNhanViens select new { n.MaNhomNV, n.TenNhomNV };
            data.DataSource = Nhom;
        }

        public void GetDataPhanQuyen(DataGridView data, string maNhom)
        {
            var quyen = from p in qlcf.PhanQuyens                   
                        join m in qlcf.ManHinhs
                             on p.MaManHinh equals m.MaManHinh
                        join g in qlcf.NhomNhanViens
                       on p.MaNhomNV equals g.MaNhomNV
                        where maNhom == p.MaNhomNV
                        select new { p.MaManHinh, m.TenManHinh,p.MaNhomNV,g.TenNhomNV, p.CoQuyen };
            data.DataSource = quyen;
        }

        public void CapNhatPhanQuyen(string mamanhinh,string manhom,bool coquyen)
        {
            PhanQuyen pq = qlcf.PhanQuyens.Where(t => t.MaManHinh == mamanhinh && t.MaNhomNV == manhom).FirstOrDefault();
            pq.CoQuyen = coquyen;
            qlcf.SubmitChanges();
        }

        public bool PhanQuyenManHinh(string mamanhinh)
        {
            PhanQuyen pq = qlcf.PhanQuyens.Where(t => t.MaManHinh == mamanhinh && t.MaNhomNV==ThongTin.MaNhom1).FirstOrDefault();
            return pq.CoQuyen.Value;
        }

        public string GetMaNhom(string TenTK)
        {
            var tk = qlcf.TaiKhoanNhomNVs.Where(t => t.TaiKhoan == TenTK).Select(t => t.MaNhomNV).FirstOrDefault();
            return tk.ToString();
        }
        public void GetDataTK(DataGridView data)
        {
            var Nhom = from n in qlcf.TaiKhoans select new {n.TenTaiKhoan,n.MatKhau };
            data.DataSource = Nhom;
        }

        public void GetDataCboTaiKhoanNhom(ComboBox cbo)
        {
            var Nhom = from n in qlcf.NhomNhanViens select n;
            cbo.DataSource = Nhom;
            cbo.DisplayMember = "TenNhomNV";
            cbo.ValueMember = "MaNhomNV";
        }

        public void GetDataCboPhanQuyenTheoMaNhom(ComboBox cbo)
        {
            
            var Nhom = from n in qlcf.NhomNhanViens select n;
            cbo.DataSource = Nhom;
            cbo.DisplayMember = "TenNhomNV";
            cbo.ValueMember = "MaNhomNV";
        }

        public void GetDataCboPhanQuyenTheoManHinh(ComboBox cbo)
        {
            var Nhom = from n in qlcf.ManHinhs select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaManHinh";
            cbo.DisplayMember = "TenManHinh";
        }

        public void TimKiemTheoMaManHinh(string mamh,DataGridView data)
        {
            var quyen = from p in qlcf.PhanQuyens
                        join m in qlcf.ManHinhs
                             on p.MaManHinh equals m.MaManHinh
                        join g in qlcf.NhomNhanViens
 on p.MaNhomNV equals g.MaNhomNV
                        where mamh == p.MaManHinh
                        select new { p.MaManHinh, m.TenManHinh, g.TenNhomNV, p.CoQuyen };
            data.DataSource = quyen;
        }

        public void TimKiemTheoMaNhom(string manhom, DataGridView data)
        {
            var quyen = from p in qlcf.PhanQuyens
                        join m in qlcf.ManHinhs
                             on p.MaManHinh equals m.MaManHinh
                        join g in qlcf.NhomNhanViens
 on p.MaNhomNV equals g.MaNhomNV
                        where manhom == p.MaNhomNV
                        select new { p.MaManHinh, m.TenManHinh, g.TenNhomNV, p.CoQuyen };
            data.DataSource = quyen;
        }
        public void TimkiemTheoMaNhomNV(string manhom,DataGridView data)
        {
            var Nhom = from n in qlcf.NhomNhanViens where n.MaNhomNV==manhom select new { n.MaNhomNV, n.TenNhomNV };
            data.DataSource = Nhom;
        }

   
    }


}
