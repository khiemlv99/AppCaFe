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
    public partial class frmManHinh : Form
    {
        ManHinh_BLL qlcf = new ManHinh_BLL();
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaManHinh.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTenManHinh.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {

            }
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaManHinh.Focus();
            txtMaManHinh.Text = "";
            txtTenManHinh.Text = "";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa màn hình?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                qlcf.XoaManHinh(txtMaManHinh.Text);
                qlcf.getDataManHinh(dataGridView1);
            }
            else if (result == DialogResult.No)
            {
                return;
            }

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenManHinh.Text = "";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (qlcf.Kiemtrakhoachinh(txtMaManHinh.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm màn hình?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.ThemmanHinh(txtMaManHinh.Text, txtTenManHinh.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }


            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật  màn hình?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.CapNhatManHinh(txtMaManHinh.Text, txtTenManHinh.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }
            qlcf.getDataManHinh(dataGridView1);

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void cboTimkiemManHinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.LoaddatagridTheoCboBox(cboTimkiemManHinh.SelectedValue.ToString(), dataGridView1);
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            qlcf.getDataManHinh(dataGridView1);
            qlcf.loadcbo(cboTimkiemManHinh);
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
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
