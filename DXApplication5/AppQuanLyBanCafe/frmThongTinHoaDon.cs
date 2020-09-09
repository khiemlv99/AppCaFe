using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ALL;

namespace AppQuanLyBanCafe
{
    public partial class frmThongTinHoaDon : Form
    {
        ThucDon_BLL td = new ThucDon_BLL();
        BanKhuVuc_BLL khuvuc = new BanKhuVuc_BLL();
        public double tienbandau = 0;

        public class TrangThaiTraVe
        {
            private static int trangthai = 0;

            public static int Trangthai
            {
                get { return TrangThaiTraVe.trangthai; }
                set { TrangThaiTraVe.trangthai = value; }
            }
        }
        public frmThongTinHoaDon()
        {
            InitializeComponent();
            lblTenNhanvien.Text = "Tuan";
        }

        private void frmThongTinHoaDon_Load(object sender, EventArgs e)
        {
            loadThongTinCanThiet();
            loadCboMagiamGia();
        }

        public void loadThongTinCanThiet()
        {
            try
            {
                lblMaBan.Text = frmQuanLyKhu.BanDangChon.Mabandangchon.ToString();
                DateTime date = DateTime.Now;
                lblNgayMua.Text = date.ToString("dd/MM/yyyy hh:mm:ss");
                td.loadDanhSachMonDaGoi(dtgHoadontamtinh, frmQuanLyKhu.BanDangChon.Mabandangchon);
                lblTongTien.Text = td.TinhTongTienDaGoi(frmQuanLyKhu.BanDangChon.Mabandangchon).ToString();

            }
            catch { }          

        }

        private void txtTienKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double tienkhachdua = double.Parse(txtTienKhach.Text.ToString().Trim());
                double tongtien = double.Parse(lblTongTien.Text.Trim());
                txtTienThua.Text = (tienkhachdua - tongtien).ToString("0.0");
            }

        }

        public void loadCboMagiamGia()
        {
            cboMaGiamGia.DisplayMember = "MaGiamGia";
            cboMaGiamGia.ValueMember = "PhantramGiam";
            cboMaGiamGia.DataSource = td.loadComboMagiamGia();
        }

        private void cboMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaGiamGia_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cboMaGiamGia.SelectedValue == null)
                return;
            if (cboMaGiamGia.SelectedValue.ToString() == "0")
            {
                tienbandau = double.Parse(td.TinhTongTienDaGoi(frmQuanLyKhu.BanDangChon.Mabandangchon).ToString("0.0"));
                lblTongTien.Text = tienbandau.ToString();
                return;
            }
            float phantram = float.Parse(cboMaGiamGia.SelectedValue.ToString());
            double tientam = double.Parse(lblTongTien.Text.Trim());
            double tongtien = tientam * (phantram / 100);
            lblTongTien.Text = tongtien.ToString("0.0");

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if(txtTienKhach.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền khách đưa","Thông báo");
                txtTienKhach.Focus();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn xuất hóa đơn không?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlr == DialogResult.No)
                {
                    return;
                }
                int maban = int.Parse(lblMaBan.Text.ToString());
                DateTime date = DateTime.Now;
                DateTime ngay = DateTime.Parse(lblNgayMua.Text.ToString());
                double tongtien = double.Parse(lblTongTien.Text.ToString());

                ThongTinHoaDon.NgayXuat = date.ToString();
                ThongTinHoaDon.tenNhanVien = lblTenNhanvien.Text;
                ThongTinHoaDon.tienkhachdua = txtTienKhach.Text;
                ThongTinHoaDon.tientralai = txtTienThua.Text;
                ThongTinHoaDon.tongTien = lblTongTien.Text;
                ThongTinHoaDon.giamgia ="";

                td.themHoaDon(maban, ngay, tongtien, cboMaGiamGia.Text.ToString());

                td.clearMonDaGoi(frmQuanLyKhu.BanDangChon.Mabandangchon);
                td.CapNhatLaiKho(frmQuanLyKhu.BanDangChon.Mabandangchon);
                MessageBox.Show("Xuất hóa đơn thành công!");

                khuvuc.CapNhatTrong(frmQuanLyKhu.BanDangChon.Mabandangchon);

                frmInHoaDon frm = new frmInHoaDon();
                frm.Show();
                this.Hide();
            }          
          
        }
    }
}
