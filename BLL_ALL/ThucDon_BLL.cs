using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BLL_ALL
{
    public class ThucDon_BLL
    {
        QLBanCafeDataContext qlThucDon = new QLBanCafeDataContext();

        public ThucDon_BLL() { }

        public void ThemThucDon(string mamon, string tenmon, int gia, string dvt, PictureBox pictureHinh)
        {

            Menu mn = qlThucDon.Menus.Where(t => t.MaMon.Equals(mamon)).FirstOrDefault();
            if (mn == null)
            {
                try
                {
                    MemoryStream stream = new MemoryStream();
                    pictureHinh.Image.Save(stream, pictureHinh.Image.RawFormat);
                    Menu mnu = new Menu();
                    mnu.MaMon = mamon;
                    mnu.TenMon = tenmon;
                    mnu.Gia = gia;
                    mnu.DVT = dvt;
                    byte[] img = stream.ToArray();
                    mnu.HinhAnh = img;
                    qlThucDon.Menus.InsertOnSubmit(mnu);
                    qlThucDon.SubmitChanges();
                    MessageBox.Show("Thêm món " + tenmon + " thành công!", "Thông báo!");
                }
                catch
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông báo");
                }
                
            }
        }

        public void loadDataGridView(DataGridView da)
        {

            var mnu = from m2 in qlThucDon.Menus select new { m2.MaMon, m2.TenMon, m2.Gia, m2.DVT ,m2.HinhAnh};
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã món");
            dt.Columns.Add("Tên món");
            dt.Columns.Add("Giá");
            dt.Columns.Add("DVT");
            dt.Columns.Add("Hình ảnh");
            dt.Columns[4].DataType = System.Type.GetType("System.Byte[]");
            foreach(var t in mnu)
            {
                if(t.HinhAnh !=null)
                {
                    dt.Rows.Add(t.MaMon, t.TenMon, t.Gia, t.DVT, t.HinhAnh.ToArray());
                }
            }
            dt.Columns[0].ColumnName = "MaMon";
            dt.Columns[1].ColumnName = "TenMon";
            dt.Columns[2].ColumnName = "Gia";
            dt.Columns[3].ColumnName = "DVT";
            dt.Columns[4].ColumnName = "HinhAnh";
            
            da.DataSource = dt;
            
        }


        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        #region Danh sach mon goi

        public void themDanhSachMonGoi(int maban, string mamon,int soluon, decimal gia )
        {
            DanhSachMonGoi ds = new DanhSachMonGoi();
            ds.MaBan = maban;
            ds.MaMon = mamon;
            ds.SoLuong = soluon;
            ds.Gia = gia;
            qlThucDon.DanhSachMonGois.InsertOnSubmit(ds);
            qlThucDon.SubmitChanges();
        }

        public void loadDanhSachMonDaGoi(DataGridView  da, int maban)
        {
            var ds = from m in qlThucDon.DanhSachMonGois where m.MaBan == maban select new { m.MaBan,m.MaMon,m.SoLuong,m.Gia};
            da.DataSource = ds;
        }

        public bool checkMonDaGoi(int maban ,string mamon)
        {
            var mon = qlThucDon.DanhSachMonGois.Where(t => t.MaMon == mamon && t.MaBan == maban).FirstOrDefault();
            if(mon != null)
            {
                return false;
            }
            return true;
        }

        public void clearMonDaGoi(int maban)
        {
            var mon = qlThucDon.DanhSachMonGois.Where(t => t.MaBan == maban).ToList();
            foreach(DanhSachMonGoi ds in mon)
            {
                if (mon != null)
                {
                    qlThucDon.DanhSachMonGois.DeleteOnSubmit(ds);
                }
            }
           
            qlThucDon.SubmitChanges();
        }

        public long TinhTongTienDaGoi(int maban)
        {
            long tongtien = 0;
            var tt = (from m in qlThucDon.DanhSachMonGois where m.MaBan == maban select m).ToList();
            foreach (DanhSachMonGoi ds in tt)
            {
                tongtien += TinhTongTienTamThoi(ds.MaMon);
            }

            return tongtien;
        }

        public long TinhTongTienTamThoi(string mamon)
        {
            long tongtien = 0;
            var sl = (from m in qlThucDon.DanhSachMonGois where m.MaMon == mamon select m).FirstOrDefault();
            var dg = (from d in qlThucDon.Menus where d.MaMon == mamon select d).FirstOrDefault();
            int soluong = Int32.Parse(sl.SoLuong.ToString());
            int dongia = (int)dg.Gia;

            tongtien = soluong * dongia;

            return tongtien;
        }
        #endregion

        public IQueryable loadComboMagiamGia()
        {
            var ch = from m in qlThucDon.GiamGias select new { m.MaGiamGia, m.TenSuKien, m.PhantramGiam };
            return ch;
        }

        #region Cap nhat so luong vao kho
        public int laySoLuongSuDungCuaMon(string mamon, string manguyenlieu)
        {
            int soluong = 0;
            var mm = (qlThucDon.NhomNguyenLieus.Where(t => t.MaMon == mamon && t.MaNguyenLieu == manguyenlieu)).Single();
            //foreach(NhomNguyenLieu nl in mm)
            //{
            //    soluong = (int)nl.SoLuongSuDung;
            //}
            var ahihi = (from m in qlThucDon.NhomNguyenLieus where m.MaMon == mamon && m.MaNguyenLieu == manguyenlieu select m).Single();
            soluong = int.Parse(ahihi.SoLuongSuDung.ToString());
            return soluong;
        }

        public int laySoLuongGiamTru(int maban)
        {
            int soluongsudung = 0;
            var soluongs = (qlThucDon.DanhSachMonGois.Where(t => t.MaBan == maban)).FirstOrDefault();
            var nhomnl = (from k in qlThucDon.NhomNguyenLieus select k).ToList();
            //foreach(DanhSachMonGoi ds in soluongs)
            //{
            foreach (NhomNguyenLieu n in nhomnl)
            {
                soluongsudung = (int)soluongs.SoLuong * laySoLuongSuDungCuaMon(n.MaMon, n.MaNguyenLieu);
            }
            //}
            return soluongsudung;
        }

        public void CapNhatLaiKho(int maban)
        {
            //lay ma mon theo maban
            var mmon = (from m in qlThucDon.Menus join n in qlThucDon.NhomNguyenLieus on m.MaMon equals n.MaMon
                       join ds in qlThucDon.DanhSachMonGois on m.MaMon equals ds.MaMon
                       where ds.MaBan == maban
                       select n.MaMon).FirstOrDefault();
            
           


            var nguyenlieus = (from k in qlThucDon.KhoNguyenLieus
                              join n1 in qlThucDon.NhomNguyenLieus
                                  on k.MaNguyenLieu equals n1.MaNguyenLieu
                              where n1.MaMon == mmon
                              select k.MaNguyenLieu).ToList();

            string nl = nguyenlieus.ToString();

            for(int i =0; i< nguyenlieus.Count;i++)
            {
                var kho = (from k in qlThucDon.KhoNguyenLieus where k.MaNguyenLieu == nguyenlieus[i] select k).ToList();
                foreach (KhoNguyenLieu k in kho)
                {
                    KhoNguyenLieu hihi = qlThucDon.KhoNguyenLieus.Where(t => t.MaNguyenLieu == k.MaNguyenLieu).FirstOrDefault();
                    if (hihi != null)
                    {
                        hihi.SoLuong = hihi.SoLuong - laySoLuongGiamTru(maban);

                    }
                }
            }           

            
            //KhoNguyenLieu hihi = qlThucDon.KhoNguyenLieus.Where(t => t.MaNguyenLieu == khi.MaNguyenLieu).FirstOrDefault();
            //if(hihi!= null)
            //{
            //    hihi.SoLuong = hihi.SoLuong - laySoLuongGiamTru(maban);
            //}
            qlThucDon.SubmitChanges();
        }
        #endregion


        #region Cap nhat chi tiet mon da goi
        public void capNhatSoLuongMon(string mamon, int maban, int soluong)
        {
            DanhSachMonGoi mons = qlThucDon.DanhSachMonGois.Where(t => t.MaBan == maban && t.MaMon == mamon).FirstOrDefault();
            if(mons != null)
            {
                mons.SoLuong = soluong;
            }
            qlThucDon.SubmitChanges();
        }

        public void xoaMonDaGoi(string mamon , int maban)
        {
            DanhSachMonGoi mons = qlThucDon.DanhSachMonGois.Where(t => t.MaMon == mamon && t.MaBan == maban).FirstOrDefault();
            if (mons != null)
                qlThucDon.DanhSachMonGois.DeleteOnSubmit(mons);
            qlThucDon.SubmitChanges();
        }
        #endregion


        #region Hoa don
        public void themHoaDon(int maban,DateTime ngayxuat, double tongtien, string magiamgia)
        {
            HoaDon hd = new HoaDon();
            hd.NgayXuat = ngayxuat;
            hd.TongTien =(decimal) tongtien;
            hd.MaGiamGia = magiamgia;
            qlThucDon.HoaDons.InsertOnSubmit(hd);
            qlThucDon.SubmitChanges();
            List<SanPhamTrongGioHang> lst = new List<SanPhamTrongGioHang>();
            var mons = (from m in qlThucDon.DanhSachMonGois where m.MaBan == maban select m).ToList();
            foreach(DanhSachMonGoi ds in mons)
            {
                ChiTietHD ct = new ChiTietHD();
                ct.MaHoaDon = hd.MaHoaDon;
                ct.MaBan = ds.MaBan;
                ct.MaMon = ds.MaMon;
                ct.SoLuong = ds.SoLuong;
                ct.DonGia = ds.Gia;
                Menu mn = qlThucDon.Menus.Where(t => t.MaMon == ds.MaMon).FirstOrDefault();
                SanPhamTrongGioHang sp = new SanPhamTrongGioHang(mn.TenMon.ToString(),ds.SoLuong.ToString(),ds.Gia.ToString());
                lst.Add(sp);
                qlThucDon.ChiTietHDs.InsertOnSubmit(ct);
            }
            ThongTinHoaDon.sanhams = lst;
            qlThucDon.SubmitChanges();
        }

        #endregion

        #region Chinh sua thuc don

        public void xoaDoUong(string mamon)
        {
            try
            {
                Menu td = qlThucDon.Menus.Where(t => t.MaMon == mamon).FirstOrDefault();
                DanhSachMonGoi ds = qlThucDon.DanhSachMonGois.Where(t => t.MaMon == mamon).FirstOrDefault();
                ChiTietHD ct = qlThucDon.ChiTietHDs.Where(t => t.MaMon == mamon).FirstOrDefault();
                if(td!= null)
                {
                    if(ds == null && ct == null)
                    {
                        qlThucDon.Menus.DeleteOnSubmit(td);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đồ uống đã tồn tại không được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }              

                qlThucDon.SubmitChanges();
            }
            catch
            {
            }
        }



        public void capNhatDoUong(string mamon,string tenmon, double gia, string dvt,PictureBox pic)
        {
            Menu mnu = qlThucDon.Menus.Where(t => t.MaMon == mamon).FirstOrDefault();
            if(mnu!=null)
            {
                MemoryStream stream = new MemoryStream();
                pic.Image.Save(stream, pic.Image.RawFormat);
                mnu.TenMon = tenmon;
                mnu.Gia =(decimal) gia;
                mnu.DVT = dvt;
                byte[] img = stream.ToArray();
                mnu.HinhAnh = img;
                qlThucDon.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!","Thông báo!");
            }
        }

        #endregion
    }
}
