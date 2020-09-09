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
using System.IO;

namespace AppQuanLyBanCafe
{
    public partial class frmThucDon : Form
    {

        ThucDon_BLL thucdonmnu = new ThucDon_BLL();
        
        
        public frmThucDon()
        {
            InitializeComponent();
            
        }

        private void btnThemDoUong_Click(object sender, EventArgs e)
        {
            frmThemThucDon thucdon = new frmThemThucDon(this);
            thucdon.ShowDialog();
            thucdon.Hide();
            thucdonmnu.loadDataGridView(dtgThucDon);
        }

        private void frmThucDon_Load(object sender, EventArgs e)
        {
            try
            {
                dtgThucDon.RowTemplate.Height = 120;
                thucdonmnu.loadDataGridView(dtgThucDon);
            }
            catch { }

        }

        private void btnXoaDoUong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa đồ uống này!", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlr == DialogResult.No)
            {
                return;
            }
            string mmon = dtgThucDon.CurrentRow.Cells[0].Value.ToString();
            thucdonmnu.xoaDoUong(mmon);
            thucdonmnu.loadDataGridView(dtgThucDon);
        }

        private void btnUpdatedoUong_Click(object sender, EventArgs e)
        {
            frmCapNhatDoUong frm = new frmCapNhatDoUong(this);
            frm.ShowDialog();
            frm.Hide();
            thucdonmnu.loadDataGridView(dtgThucDon);
        }

        private void dtgThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                thucDon.Mamon = dtgThucDon.CurrentRow.Cells[0].Value.ToString();
                thucDon.Tenmon = dtgThucDon.CurrentRow.Cells[1].Value.ToString();
                thucDon.Gia = double.Parse(dtgThucDon.CurrentRow.Cells[2].Value.ToString());
                thucDon.DVT = dtgThucDon.CurrentRow.Cells[3].Value.ToString();
                byte[] data = (byte[])dtgThucDon.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(data);
                thucDon.Hinhanh = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
          
        } 
    }
}
