using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL_ALL;
namespace AppQuanLyBanCafe
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        PhanQuyen_BLL pq = new PhanQuyen_BLL();
        List<DevExpress.XtraEditors.SimpleButton> arrBtn = new List<DevExpress.XtraEditors.SimpleButton>();
        public frmMain()
        {
            InitializeComponent();
            CustomizeDesign();

        }

        #region Custom and setup Menu
        public void CustomizeDesign()
        {
            pnQuanLyBanHang.Visible = false;
            pnQuanLyKho.Visible = false;
            pnQuanLyTaiKhoan.Visible = false;
        }

        public void HideSubMenu()
        {
            if (pnQuanLyBanHang.Visible == true)
                pnQuanLyBanHang.Visible = false;
            if (pnQuanLyKho.Visible == true)
                pnQuanLyKho.Visible = false;
            if (pnQuanLyTaiKhoan.Visible == true)
                pnQuanLyTaiKhoan.Visible = false;
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        private void btnQLBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(pnQuanLyBanHang);
        }

        private void btnQLKho_Click(object sender, EventArgs e)
        {
            showSubMenu(pnQuanLyKho);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            showSubMenu(pnQuanLyTaiKhoan);
        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQLKhu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyKhu());
            showSubMenu(pnQuanLyBanHang);
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(childForm);
            pnContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnChiTietBan_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanQuyenTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhanQuyen());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            arrBtn.Add(btnQLBanHang); arrBtn.Add(btnChiTietBan); arrBtn.Add(btnThucDon); arrBtn.Add(btnQLKhu); arrBtn.Add(btnQLKho); arrBtn.Add(btnNguyenLieu); arrBtn.Add(btnNhomNguyenLieu); arrBtn.Add(btnQLTaiKhoan); arrBtn.Add(btnThongTinTK); arrBtn.Add(btnPhanQuyenTK);

            foreach (DevExpress.XtraEditors.SimpleButton btn in arrBtn)
            {
                if (pq.PhanQuyenManHinh(btn.Tag.ToString()))
                {
                    btn.Visible = true;
                    btn.Enabled = true;
                }
                else
                {
                    btn.Visible = false;
                    btn.Enabled = false;
                }

            }
        }

        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTaiKhoan());
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            openChildForm(new frmManHinh());
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyKho());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThucDon());
        }

        private void btnNhomNguyenLieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyKhuVuc());
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeDoanhThu());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
            
        }
    }
}