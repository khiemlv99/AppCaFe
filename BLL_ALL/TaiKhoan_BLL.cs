using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL_ALL
{
    public class TaiKhoan_BLL
    {
        QLBanCafeDataContext qlcf = new QLBanCafeDataContext();
        public void getDataTaiKhoan(DataGridView data)
        {
            var Nhom = from n in qlcf.TaiKhoans join t in qlcf.TaiKhoanNhomNVs on n.TenTaiKhoan equals t.TaiKhoan join g in qlcf.NhomNhanViens on t.MaNhomNV equals g.MaNhomNV select new { n.TenTaiKhoan, n.MatKhau, g.TenNhomNV };
            data.DataSource = Nhom;
        }

        public void Timkiemtaikhoan(DataGridView data,String ten)
        {
            var Nhom = from n in qlcf.TaiKhoans join t in qlcf.TaiKhoanNhomNVs on n.TenTaiKhoan equals t.TaiKhoan join g in qlcf.NhomNhanViens on t.MaNhomNV equals g.MaNhomNV select new { n.TenTaiKhoan, n.MatKhau, g.TenNhomNV };
            data.DataSource = Nhom;
        }

        public bool Kiemtrakhoachinh(string mataikhoan)
        {
            TaiKhoan tk = qlcf.TaiKhoans.Where(t => t.TenTaiKhoan == mataikhoan).FirstOrDefault();
            if (tk == null)
            {
                return true;
            }
            return false;
        }

        public void ThemTaiKhoan(string tentk, string matkhau,string manhom)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenTaiKhoan = tentk;
            tk.MatKhau = matkhau;
            qlcf.TaiKhoans.InsertOnSubmit(tk);

            TaiKhoanNhomNV nhom = new TaiKhoanNhomNV();
            nhom.MaNhomNV = manhom;
            nhom.TaiKhoan = tentk;
            qlcf.TaiKhoanNhomNVs.InsertOnSubmit(nhom);
            qlcf.SubmitChanges();
        }

        public void CapNhatTaiKhoan(string tentk, string matkhau, string manhom)
        {
            TaiKhoan tk = qlcf.TaiKhoans.Where(t => t.TenTaiKhoan == tentk).FirstOrDefault();
            tk.MatKhau = matkhau;

            TaiKhoanNhomNV nhom = qlcf.TaiKhoanNhomNVs.Where(t => t.TaiKhoan == tentk).FirstOrDefault();
            qlcf.TaiKhoanNhomNVs.DeleteOnSubmit(nhom);

            TaiKhoanNhomNV nhom1 = new TaiKhoanNhomNV();
            nhom1.MaNhomNV = manhom;
            nhom1.TaiKhoan = tentk;
            qlcf.TaiKhoanNhomNVs.InsertOnSubmit(nhom1);

            qlcf.SubmitChanges();
        }

        public void XoaTaiKhoan(string tentk)
        {
            TaiKhoanNhomNV nhom = qlcf.TaiKhoanNhomNVs.Where(t => t.TaiKhoan == tentk).FirstOrDefault();
            qlcf.TaiKhoanNhomNVs.DeleteOnSubmit(nhom);

            TaiKhoan tk = qlcf.TaiKhoans.Where(t => t.TenTaiKhoan == tentk).FirstOrDefault();
            qlcf.TaiKhoans.DeleteOnSubmit(tk);
            qlcf.SubmitChanges();
        }

        public void loadcbo(ComboBox cbo)
        {
            var Nhom = from n in qlcf.TaiKhoans select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "TenTaiKhoan";
            cbo.DisplayMember = "TenTaiKhoan";
        }
        public void loadcboNhom(ComboBox cbo)
        {
            var Nhom = from n in qlcf.NhomNhanViens select n;
            cbo.DataSource = Nhom;
            cbo.ValueMember = "MaNhomNV";
            cbo.DisplayMember = "TenNhomNV";
        }
        public void LoaddatagridTheoCboBox(string ten,DataGridView data)
        {
            var Nhom = from n in qlcf.TaiKhoans where (n.TenTaiKhoan == ten) join t in qlcf.TaiKhoanNhomNVs on n.TenTaiKhoan equals t.TaiKhoan join g in qlcf.NhomNhanViens on t.MaNhomNV equals g.MaNhomNV select new { n.TenTaiKhoan, n.MatKhau, g.TenNhomNV };
            data.DataSource = Nhom;
        }
    }
}
