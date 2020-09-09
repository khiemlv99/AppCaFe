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
    public partial class frmPhanQuyen : Form
    {
        PhanQuyen_BLL qlcf= new PhanQuyen_BLL();

        NhomNV_BLL qlcff = new NhomNV_BLL();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadCBo();
        }

        public void loadDataGridView()
        {
            qlcf.GetDataNhomTK(grdViewNhomTaiKhoan);
            
        }

        private void grdViewNhomTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { qlcf.GetDataPhanQuyen(grdviewPhanQuyen, grdViewNhomTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString());
            int row = e.RowIndex;
            txtNhomNV.Text = grdViewNhomTaiKhoan.Rows[row].Cells[0].Value.ToString();
            txtTenNhomNV.Text = grdViewNhomTaiKhoan.Rows[row].Cells[1].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
            }
            catch
            {

            }
           

        }

        private void grdviewPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            qlcf.CapNhatPhanQuyen(txtMaManHinh.Text,txtMaNhomNV.Text,checkBox1.Checked);
            qlcf.GetDataPhanQuyen(grdviewPhanQuyen, grdViewNhomTaiKhoan.CurrentRow.Cells[0].Value.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadCBo()
        {
            qlcf.GetDataCboPhanQuyenTheoManHinh(cboMaManHinh);
            qlcf.GetDataCboPhanQuyenTheoMaNhom(cboTimKiemTheoMaMH);
            qlcf.GetDataCboTaiKhoanNhom(cboTimkiemTaiKhoan);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void cboTimkiemTaiKhoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.TimkiemTheoMaNhomNV(cboTimkiemTaiKhoan.SelectedValue.ToString(), grdViewNhomTaiKhoan);
        }

        private void cboTimKiemTheoMaMH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.TimKiemTheoMaNhom(cboTimKiemTheoMaMH.SelectedValue.ToString(), grdviewPhanQuyen);
        }

        private void cboMaManHinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.TimKiemTheoMaManHinh(cboMaManHinh.SelectedValue.ToString(), grdviewPhanQuyen);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtNhomNV.Text = "";
            txtTenNhomNV.Text = "";
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phân quyền?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                qlcff.XoaNhom(txtNhomNV.Text);
                qlcff.getDataNhomNhanVien(grdViewNhomTaiKhoan);
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenNhomNV.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (qlcff.Kiemtrakhoachinh(txtNhomNV.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm phân quyền?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcff.ThemNhom(txtNhomNV.Text, txtTenNhomNV.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
              

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật phân quyền?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcff.CapNhatNhom(txtNhomNV.Text, txtTenNhomNV.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
               
            }
            qlcff.getDataNhomNhanVien(grdViewNhomTaiKhoan);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void grdviewPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                  int row = e.RowIndex;
            txtMaNhomNV.Text = grdviewPhanQuyen.Rows[row].Cells[2].Value.ToString();
            txtMaManHinh.Text = grdviewPhanQuyen.Rows[row].Cells[0].Value.ToString();
            checkBox1.Checked =(bool) grdviewPhanQuyen.Rows[row].Cells[4].Value;
            }
            catch
            {}
          

            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

       
    }
}
