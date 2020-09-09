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
    public partial class frmQuanLyKho : Form
    {
        Kho_BLL qlcf = new Kho_BLL();
        public frmQuanLyKho()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            qlcf.getDataNguyenLieu(grdViewNguyenlieu);
            qlcf.loadCboBox(cboTimkiem);
            qlcf.loadCboBoxNhom(cboMaMon);
            qlcf.loadNhomNguyenLieu(grdViewNhomNguyenLieu);

            btnCapNhat.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void cboTimkiem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.timkiemtheomanguyenlieu(cboTimkiem.SelectedValue.ToString(), grdViewNguyenlieu);
        }

        private void grdViewNguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtmanguyenlieu.Text = grdViewNguyenlieu.Rows[row].Cells[1].Value.ToString();
                txtTennguyenlieu.Text = grdViewNguyenlieu.Rows[row].Cells[2].Value.ToString();
                numSoLuong.Value = int.Parse(grdViewNguyenlieu.Rows[row].Cells[3].Value.ToString());
                txtDonGia.Text = grdViewNguyenlieu.Rows[row].Cells[4].Value.ToString();
                txtDVT.Text = grdViewNguyenlieu.Rows[row].Cells[5].Value.ToString();
                dateTimePicker1.Value = (DateTime)grdViewNguyenlieu.Rows[row].Cells[6].Value;

            }
            catch
            {

            }
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtmanguyenlieu.Text = "";
            txtTennguyenlieu.Text = "";
            numSoLuong.Value = 1;
            txtDonGia.Text = "";
            txtDVT.Text = "";

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nguyên liệu?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                qlcf.Xoaallnhomnguyenlieu(txtmanguyenlieu.Text);
                qlcf.Xoanguyenlieu(txtmanguyenlieu.Text);
                qlcf.getDataNguyenLieu(grdViewNguyenlieu);
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (qlcf.kiemtrakhoachinh(txtmanguyenlieu.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nguyên liệu?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.Themnguyenlieu(txtmanguyenlieu.Text, txtTennguyenlieu.Text, numSoLuong.Value.ToString(), txtDonGia.Text, txtDVT.Text, dateTimePicker1.Value);

                }
                else if (result == DialogResult.No)
                {
                    return;
                }


            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nguyên liệu?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.CapNhatnguyenlieu(txtmanguyenlieu.Text, txtTennguyenlieu.Text, numSoLuong.Value.ToString(), txtDonGia.Text, txtDVT.Text, dateTimePicker1.Value);

                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }
            qlcf.getDataNguyenLieu(grdViewNguyenlieu);

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnThemNhomNguyenLieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (qlcf.kiemtrakhoachinhnhom(cboMaMon.SelectedValue.ToString(), grdViewNguyenlieu.CurrentRow.Cells[1].Value.ToString()))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm nhóm?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        qlcf.ThemNhomNguyenLieu(cboMaMon.SelectedValue.ToString(), grdViewNguyenlieu.CurrentRow.Cells[1].Value.ToString(), numSoLuongNhom.Value.ToString());
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                }
            }
            catch
            {

            }

            qlcf.loadNhomNguyenLieu(grdViewNhomNguyenLieu);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                qlcf.CapNhatNhomNguyenLieu(grdViewNhomNguyenLieu.CurrentRow.Cells[1].Value.ToString(), grdViewNhomNguyenLieu.CurrentRow.Cells[0].Value.ToString(), numSoLuongNhom.Value.ToString());
                qlcf.loadNhomNguyenLieu(grdViewNhomNguyenLieu);
            }
            catch
            {

            }

        }

        private void grdViewNhomNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            frmThongKeNhapKho kho = new frmThongKeNhapKho();
            kho.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            btnCapNhat.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            
            if (!qlcf.kiemtrakhoachinhnhom(grdViewNhomNguyenLieu.CurrentRow.Cells[0].Value.ToString(), grdViewNhomNguyenLieu.CurrentRow.Cells[1].Value.ToString()))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhóm nguyên liệu?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    //qlcf.Xoaallnguyenlieu(grdViewNhomNguyenLieu.CurrentRow.Cells[1].Value.ToString());
                    qlcf.XoaNhomNguyenLieu(grdViewNhomNguyenLieu.CurrentRow.Cells[0].Value.ToString(), grdViewNhomNguyenLieu.CurrentRow.Cells[1].Value.ToString());
                   
                     qlcf.loadNhomNguyenLieu(grdViewNhomNguyenLieu);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }

        }

        private void cboMaMon_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.loadDatatheoCbo(cboMaMon.SelectedValue.ToString(), grdViewNhomNguyenLieu);
        }
    }
}
