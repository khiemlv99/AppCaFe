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
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL qlcf = new NhanVien_BLL();
        public frmNhanVien()
        {
            InitializeComponent();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int row = e.RowIndex;
            txtMaNhanVien.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            cboNhomNV.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            }
            catch
            {

            }

            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
        }

        private void cboNhomNV_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboTimkiemNhóm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            qlcf.LoaddatagridTheoCboBox(cboTimkiemNhóm.SelectedValue.ToString(), dataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                qlcf.XoaNV(txtMaNhanVien.Text);
                qlcf.getNhanVien(dataGridView1);
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

            txtTenNhanVien.Text = "";
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (qlcf.Kiemtrakhoachinh(txtMaNhanVien.Text))
            {

                DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.ThemNV(txtMaNhanVien.Text, txtTenNhanVien.Text, cboNhomNV.SelectedValue.ToString());
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
              
                
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.CapNhatNV(txtMaNhanVien.Text, txtTenNhanVien.Text, cboNhomNV.SelectedValue.ToString());
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                
            }
            qlcf.getNhanVien(dataGridView1);

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            qlcf.getNhanVien(dataGridView1);
            qlcf.loadcbo(cboTimkiemNhóm);
            qlcf.loadcboNhom(cboNhomNV);
            qlcf.getBangPhanCong(dataGridView2);
            qlcf.loadcboCalam(cboCaLamViec);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            qlcf.LoaddatagridTheodatetimepicker(dateTimePicker1.Value, dataGridView2);
        }

        private void btnThemPhanCong_Click(object sender, EventArgs e)
        {
            if (qlcf.Kiemtrakhoachinhcv(cboCaLamViec.SelectedValue.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), dateTimePicker1.Value))
            {

                DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên vào ca làm ?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    qlcf.ThemBanPhanCong(cboCaLamViec.SelectedValue.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), dateTimePicker1.Value);
                    qlcf.getBangPhanCong(dataGridView2);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
              
            }
            else {
                MessageBox.Show("Trùng lịch");
                return;
            }
                

            

        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            frmTinhLuong frm = new frmTinhLuong();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        WordExport word = new WordExport();
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn in hợp đồng lao động?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                word.HopDongLaoDong(DateTime.Now.Day.ToString()+"/" + DateTime.Now.Month.ToString()+"/" + DateTime.Now.Year.ToString(), txtTenNhanVien.Text, "269/8 Lý Thường Kiệt Phường 15 Quận 11", "05/11/1999");
            }
            else if (result == DialogResult.No)
            {
                return;
            }
          
        }
    }
}
