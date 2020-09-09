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
using DevExpress.XtraEditors;
namespace AppQuanLyBanCafe
{
    public partial class frmQuanLyKhuVuc : Form
    {
        Ban_BLL ban = new Ban_BLL();

        BanKhuVuc_BLL qlban = new BanKhuVuc_BLL();
        List<TabPage> lstTabPage = new List<TabPage>();
        List<SimpleButton> lstBan = new List<SimpleButton>();
        public int i = 0;
        int temp = 0;
        public frmQuanLyKhuVuc()
        {
            InitializeComponent();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            txtMaBan.Enabled = false;
            txtTenBan.Enabled = false;
            txtMaBan.Text = ban.TuDongSinhMaBan().ToString();
            txtTenBan.Text = ban.TuDongSinhTenBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bàn?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ban.XoaBan(txtMaBan.Text.Trim());
                loadlai();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenBan.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        

        private void frmQuanLyKhuVuc_Load(object sender, EventArgs e)
        {
            ban.loadcboKhu(cboKhuVuc);
            taoKhuVuc();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;

            btnSuaKhu.Enabled = false;
            btnXoaKhu.Enabled = false;
            btnLuuKhu.Enabled = false;
        }

        void taoKhuVuc()
        {
            foreach (KhuVuc k in qlban.getAllKhuVuc())
            {
                TabPage tp = new TabPage(k.MaKhuVuc);
               
                tp.Click +=tp_Click;
                lstTabPage.Add(tp);
                tp.Width = this.Width / 2;
                tp.Text = k.MaKhuVuc;
                tp.BackColor = Color.Aqua;


                //qlban.getAllTableforArea(k.MaKhuVuc);
                foreach (Ban b in qlban.getAllTableforArea(k.MaKhuVuc))
                {
                    SimpleButton ban = new SimpleButton();
                    ban.Click += frmQuanLyKhu_Click;
                    lstBan.Add(ban);
                    lstBan[i].Size = new Size(50, 50);
                    lstBan[i].BackColor = Color.Aqua;
                    lstBan[i].Name = b.MaBan.ToString().Trim();
                    lstBan[i].Text = b.TenBan.ToString();
                    lstBan[i].ImageOptions.Location = ImageLocation.MiddleCenter;
                    lstBan[i].AppearanceHovered.BackColor = Color.Red;
                    lstBan[i].AppearancePressed.BackColor = Color.Pink;
                    tp.Controls.Add(lstBan[i]);

                   
                    lstBan[i].ImageOptions.Image = global::AppQuanLyBanCafe.Properties.Resources.chuadat;
                    
                  

                    if (i == temp)
                    {
                        lstBan[i].Location = new Point(30, 5);
                    }
                    else
                    {
                        if (lstBan[i - 1].Location.X + 150 > tp.Width)
                        {
                            lstBan[i].Location = new Point(30, lstBan[i - 1].Location.Y + 80);

                        }
                        else
                        {
                            lstBan[i].Location = new Point(lstBan[i - 1].Location.X + 80, lstBan[i - 1].Location.Y);
                        }
                    }
                    i++;
                }
                temp += qlban.getAllTableforArea(k.MaKhuVuc).Count;
                tp.Refresh();
                tabcrlBan.Controls.Add(tp);
            }

        }

        private void tp_Click(object sender, EventArgs e)
        {
            TabPage tp = sender as TabPage;
            txtMaKhu.Text = tp.Text;
            txtMaKhu.Enabled = false;
            btnThemKhu.Enabled = false;
            btnXoaKhu.Enabled = true;
            btnSuaKhu.Enabled = true;
            btnLuuKhu.Enabled = false;
        }

        void frmQuanLyKhu_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            txtMaBan.Text = btn.Name.ToString();
            txtTenBan.Text = btn.Text.ToString();
            cboKhuVuc.Text = ban.KhuVuc(btn.Name.ToString());
            txtTenBan.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        public void loadlai()
        {
            tabcrlBan.Controls.Clear();
            ban.loadcboKhu(cboKhuVuc);
            taoKhuVuc();
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            txtTenKhu.Enabled = true;
            btnXoaKhu.Enabled = false;
            btnLuuKhu.Enabled = true;
            btnSuaKhu.Enabled = false;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (ban.kiemtrakhoachinh(txtMaBan.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm bàn?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ban.ThemBan(txtMaBan.Text, txtTenBan.Text, "Trống", cboKhuVuc.SelectedValue.ToString());
                    loadlai();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa bàn?", "Chấp nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ban.CapNhatBan(txtMaBan.Text, txtTenBan.Text, cboKhuVuc.SelectedValue.ToString());
                    loadlai();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoaKhu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa khu vực có nghĩa là xóa tất cả bàn trong khu bạn có đồng ý?", "Chấp nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ban.XoaBanTrongKhu(txtMaKhu.Text);
                ban.XoaKhu(txtMaKhu.Text);
                
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            btnLuuKhu.Enabled = false;
            btnXoaKhu.Enabled = false;
            btnSuaKhu.Enabled = false;
            loadlai();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaKhu_Click(object sender, EventArgs e)
        {
            txtMaKhu.Enabled = false;
            btnThemKhu.Enabled = false;
            btnXoaKhu.Enabled = false;
            btnLuuKhu.Enabled = true;
        }

        private void btnLuuKhu_Click(object sender, EventArgs e)
        {
            if(ban.kiemtrakhoachinhkhuvuc(txtMaKhu.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thêm khu vực ?", "Chấp nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ban.Themkhu(txtMaKhu.Text,txtTenKhu.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa khu vực?", "Chấp nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ban.CapNhatKhu(txtMaKhu.Text, txtTenKhu.Text);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            loadlai();

            btnLuuKhu.Enabled = false;
            btnXoaKhu.Enabled = false;
            btnSuaKhu.Enabled = false;
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            txtMaBan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnHuyKhu_Click(object sender, EventArgs e)
        {
            txtMaKhu.Text = "";
            txtTenKhu.Text = "";
            txtMaKhu.Enabled = false;
            btnThemKhu.Enabled = true;
            btnXoaKhu.Enabled = false;
            btnSuaKhu.Enabled = false;
            btnLuuKhu.Enabled = false;
        }
    }
}
