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
    public partial class frmTaiKhoan : Form
    {
        TaiKhoan_BLL qlcf = new TaiKhoan_BLL();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            qlcf.getDataTaiKhoan(dataGridView1);
            qlcf.loadcbo(cboTimkiemTaiKhoan);
            qlcf.loadcboNhom(cboTenNhom);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTenTK.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtTenTK.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtMatKhau.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {

            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tài khoản?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                qlcf.XoaTaiKhoan(txtTenTK.Text);
                qlcf.getDataTaiKhoan(dataGridView1);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (qlcf.Kiemtrakhoachinh(txtTenTK.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm tài khoản?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.ThemTaiKhoan(txtTenTK.Text, txtMatKhau.Text, cboTenNhom.SelectedValue.ToString());
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
               

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật tài khoản?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.CapNhatTaiKhoan(txtTenTK.Text, txtMatKhau.Text, cboTenNhom.SelectedValue.ToString());
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
               
            }
            qlcf.getDataTaiKhoan(dataGridView1);

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void cboTimkiemTaiKhoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.LoaddatagridTheoCboBox(cboTimkiemTaiKhoan.SelectedValue.ToString(), dataGridView1);
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
