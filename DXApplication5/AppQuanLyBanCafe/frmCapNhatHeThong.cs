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
    public partial class frmCapNhatHeThong : Form
    {
        QL_NguoiDung ql = new QL_NguoiDung();
        public frmCapNhatHeThong()
        {
            InitializeComponent();
           
        }

        private void frmCapNhatHeThong_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ql.SaveConfig(cboServername.Text, cboDatabase.Text);
            this.Close();
        }

        //public void addCboBox()
        //{
        //    DataTable dt = ql.GetServerName();

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
               
        //        cboServername.Items.Add(dt.Rows[i][0].ToString());
               
        //    }

        //}

        private void cboServername_DropDown(object sender, EventArgs e)
        {
            cboServername.DataSource = ql.GetServerName();
            cboServername.DisplayMember = "ServerName";
        }
    }
}
