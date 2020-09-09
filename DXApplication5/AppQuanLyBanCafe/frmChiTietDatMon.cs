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
    public partial class frmChiTietDatMon : Form
    {
        ThucDon_BLL qlthucdon = new ThucDon_BLL();
        BanKhuVuc_BLL qlBan = new BanKhuVuc_BLL();

        static List<DSMonGoi> lst = new List<DSMonGoi>();

        public class TrangThaiTraVe
        {
            public static int trangthai = 0;
        }
        public frmChiTietDatMon()
        {
            InitializeComponent();
            qlthucdon.loadDanhSachMonDaGoi(dtgMonDaGoi, frmQuanLyKhu.BanDangChon.Mabandangchon);
            btnCapNhatMon.Enabled = false;
        }

        private void frmChiTietDatMon_Load(object sender, EventArgs e)
        {

            groupChiTietBan.Text = "Mã bàn : " + frmQuanLyKhu.BanDangChon.Mabandangchon;
            qlthucdon.loadDataGridView(dtgThucDonDat);
        }

        public void ThemMon()
        {
            string mamon = dtgThucDonDat.CurrentRow.Cells[0].Value.ToString();
            int maban = frmQuanLyKhu.BanDangChon.Mabandangchon;
            int soluong = int.Parse(numericUpDownThem.Value.ToString());
            double gia = double.Parse(dtgThucDonDat.CurrentRow.Cells[2].Value.ToString());
            
            if (qlthucdon.checkMonDaGoi(maban, mamon))
            {
                qlthucdon.themDanhSachMonGoi(maban, mamon, soluong,(decimal)gia);
                    
            }
            else
            {
                MessageBox.Show("Món này đã chọn rồi vui lòng chọn món khác!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            ThemMon();
            qlthucdon.loadDanhSachMonDaGoi(dtgMonDaGoi, frmQuanLyKhu.BanDangChon.Mabandangchon);
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if(qlBan.getAllDsMonGoi(frmQuanLyKhu.BanDangChon.Mabandangchon)>0)
            {
                qlBan.CapNhatLaiTrangThaiBan(frmQuanLyKhu.BanDangChon.Mabandangchon);
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bàn này chưa có món!", "Thông báo");
                qlBan.CapNhatTrong(frmQuanLyKhu.BanDangChon.Mabandangchon);
                this.Hide();
            }          
           
        }

        private void btnCapNhatMon_Click(object sender, EventArgs e)
        {
            int maban = int.Parse(dtgMonDaGoi.CurrentRow.Cells[0].Value.ToString());
            string mamon = dtgMonDaGoi.CurrentRow.Cells[1].Value.ToString();
            int soluong = int.Parse(updownSoLuong.Value.ToString());

            qlthucdon.capNhatSoLuongMon(mamon, maban, soluong);
            MessageBox.Show("Cập nhật thành công!");
            qlthucdon.loadDanhSachMonDaGoi(dtgMonDaGoi, frmQuanLyKhu.BanDangChon.Mabandangchon);

        }

        private void updownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            btnCapNhatMon.Enabled = true;
        }

        private void dtgMonDaGoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCapNhatMon.Enabled = true;
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            DialogResult dlr= MessageBox.Show("Bạn có muốn xóa sản phẩm này!", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlr == DialogResult.No)
            {
                return;
            }
            if (qlBan.getAllDsMonGoi(frmQuanLyKhu.BanDangChon.Mabandangchon) > 0)
            {
                int maban = int.Parse(dtgMonDaGoi.CurrentRow.Cells[0].Value.ToString());
                string mamon = dtgMonDaGoi.CurrentRow.Cells[1].Value.ToString();
                qlthucdon.xoaMonDaGoi(mamon, maban);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                qlthucdon.loadDanhSachMonDaGoi(dtgMonDaGoi, frmQuanLyKhu.BanDangChon.Mabandangchon);            
            }
            else
            {
                MessageBox.Show("Bàn này chưa có món!", "Thông báo");
                qlBan.CapNhatTrong(frmQuanLyKhu.BanDangChon.Mabandangchon);
            }
            
        }
    }
}
