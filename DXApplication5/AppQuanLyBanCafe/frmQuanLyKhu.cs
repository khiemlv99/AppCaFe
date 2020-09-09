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
    public partial class frmQuanLyKhu : Form
    {
        BanKhuVuc_BLL qlban = new BanKhuVuc_BLL();
        HoaDon_BLL hd = new HoaDon_BLL();
        List<TabPage> lstTabPage = new List<TabPage>();
        List<SimpleButton> lstBan = new List<SimpleButton>();
        public class BanDangChon
        {
            private static int mabandangchon = 0, mabanmuonchuyen = 0, mabanmuongop = 0;

            public static int Mabanmuongop
            {
                get { return BanDangChon.mabanmuongop; }
                set { BanDangChon.mabanmuongop = value; }
            }

            public static int Mabanmuonchuyen
            {
                get { return BanDangChon.mabanmuonchuyen; }
                set { BanDangChon.mabanmuonchuyen = value; }
            }
            private static bool trangthaichuyen = false, trangthaigop = false;

            public static bool Trangthaigop
            {
                get { return BanDangChon.trangthaigop; }
                set { BanDangChon.trangthaigop = value; }
            }

            public static bool Trangthaichuyen
            {
                get { return BanDangChon.trangthaichuyen; }
                set { BanDangChon.trangthaichuyen = value; }
            }
            public static int Mabandangchon
            {
                get { return mabandangchon; }
                set { mabandangchon = value; }
            }
        }       

        public int i = 0;
        int temp = 0;
        public frmQuanLyKhu()
        {
            InitializeComponent();
           
        }

        private void frmQuanLyKhu_Load(object sender, EventArgs e)
        {
            taoKhuVuc();
            BanDangChon.Trangthaichuyen = false;
            BanDangChon.Trangthaigop = false;
            BanDangChon.Mabandangchon = -1;
            BanDangChon.Mabanmuongop = -1;
            BanDangChon.Mabanmuonchuyen = -1;
           
        }

     

        void taoKhuVuc()
        {
            foreach (KhuVuc k in qlban.getAllKhuVuc())
            {
                TabPage tp = new TabPage(k.MaKhuVuc);
                lstTabPage.Add(tp);
                tp.Width = this.Width / 2;
                tp.Text = k.MaKhuVuc;
                tp.BackColor = Color.Aqua;
                

                //qlban.getAllTableforArea(k.MaKhuVuc);
                foreach(Ban b in qlban.getAllTableforArea(k.MaKhuVuc))
                {
                    SimpleButton ban = new SimpleButton();
                    ban.Click += frmQuanLyKhu_Click;
                    lstBan.Add(ban);
                    lstBan[i].Size = new Size(50, 50);
                    lstBan[i].BackColor = Color.Aqua;
                    lstBan[i].Name = b.MaBan.ToString().Trim();
                    //lstBan[i].Text = b.TenBan.ToString();
                    lstBan[i].Text += Environment.NewLine + b.TenBan.ToString();
                    lstBan[i].ImageOptions.Location = ImageLocation.TopCenter;
                    lstBan[i].AppearancePressed.BackColor = Color.Red;  
                    lstBan[i].AppearanceHovered.BackColor = Color.Pink;
                    
                    
                    tp.Controls.Add(lstBan[i]);

                    if (b.TrangThai==0)
                    {
                        lstBan[i].ImageOptions.Image = global::AppQuanLyBanCafe.Properties.Resources.chuaco;
                        lstBan[i].AutoSize = true;
                        this.lstBan[i].ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        this.lstBan[i].Appearance.Options.UseBackColor = true;
                        lstBan[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else if (b.TrangThai == 2)
                    {
                        lstBan[i].ImageOptions.Image = global::AppQuanLyBanCafe.Properties.Resources.datban;
                        lstBan[i].AutoSize = true;
                        this.lstBan[i].ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        this.lstBan[i].Appearance.Options.UseBackColor = true;
                    }
                    else
                    {
                        lstBan[i].ImageOptions.Image = global::AppQuanLyBanCafe.Properties.Resources.daco;

                        lstBan[i].AutoSize = true;
                        this.lstBan[i].ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                        this.lstBan[i].Appearance.Options.UseBackColor = true;
                        lstBan[i].Appearance.BackColor = Color.Transparent;
                    }

                    if( i == temp)
                    {
                        lstBan[i].Location = new Point(30, 5);
                    }
                    else
                    {
                        if(lstBan[i-1 ].Location.X +150 >tp.Width)
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
                tabControl.Controls.Add(tp);
            }

        }

        void frmQuanLyKhu_Click(object sender, EventArgs e)
        {
            
            SimpleButton btn = sender as SimpleButton;
            if(!BanDangChon.Trangthaichuyen)
            {
                BanDangChon.Mabandangchon = int.Parse(btn.Name.Trim());
            }
            else
            {
                BanDangChon.Mabanmuonchuyen = int.Parse(btn.Name.Trim());
                if (!qlban.kiemtratrangthaichuyenban(BanDangChon.Mabanmuonchuyen))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn chuyển bàn?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        qlban.chuyenBan(BanDangChon.Mabandangchon, BanDangChon.Mabanmuonchuyen);

                        tabControl.Controls.Clear();
                        taoKhuVuc();
                        BanDangChon.Trangthaichuyen = false;
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                   
                }
                else
                {
                    MessageBox.Show("Bàn cần chuyển đã trong trạng thái chọn");
                }
            }

            if(BanDangChon.Trangthaigop)
            {
              
                if (qlban.kiemtratrangthaichuyenban(BanDangChon.Mabanmuongop))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn gộp bàn?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        qlban.gopBan(BanDangChon.Mabanmuongop, BanDangChon.Mabandangchon);
                        tabControl.Controls.Clear();
                        taoKhuVuc();
                        BanDangChon.Trangthaigop = false;
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Bàn cần gộp đang trong trạng thái trống");
                }
            }

            

          
        }


        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if(BanDangChon.Mabandangchon != 0)
            {
                frmChiTietDatMon frm = new frmChiTietDatMon();
                frm.ShowDialog();
               

            }
           
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {

            if (!BanDangChon.Trangthaichuyen)
            {
                if (BanDangChon.Mabandangchon == 0)
                {
                    MessageBox.Show("Mời chọn bạn để gộp");
                }
                else
                {

                    foreach (SimpleButton btn in lstBan)
                    {
                        if (BanDangChon.Mabandangchon == int.Parse(btn.Name.ToString()))
                        {
                            if (qlban.kiemtratrangthaichuyenban(BanDangChon.Mabandangchon))
                            {
                                BanDangChon.Trangthaigop = true;
                                BanDangChon.Mabanmuongop = int.Parse(btn.Name.Trim());
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Bàn đang trong trạng thái Trống");
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {

            if (!BanDangChon.Trangthaichuyen)
            {
                if (BanDangChon.Mabandangchon == 0)
                {
                    MessageBox.Show("Mời chọn bạn để chuyển");
                }
                else
                {

                    foreach (SimpleButton btn in lstBan)
                    {
                        if (BanDangChon.Mabandangchon == int.Parse(btn.Name.ToString()))
                        {
                            if (qlban.kiemtratrangthaichuyenban(BanDangChon.Mabandangchon))
                            {
                                BanDangChon.Trangthaichuyen = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Bàn đang trong trạng thái Trống");
                                break;
                            }
                        }
                    }
                }
            }
                      
        }

        private void btnTraLai_Click(object sender, EventArgs e)
        {

            if (qlban.checkTrangThaiDatBan(BanDangChon.Mabandangchon))
            {
                MessageBox.Show("Hủy bàn đã đặt thành công!", "Thông báo");
                qlban.CapNhatTrong(BanDangChon.Mabandangchon);
            }
            
            BanDangChon.Trangthaichuyen = false;
            BanDangChon.Trangthaigop = false;
            BanDangChon.Mabandangchon = -1;
            BanDangChon.Mabanmuongop = -1;
            BanDangChon.Mabanmuonchuyen = -1;
            return;
           

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (qlban.kiemTraTonTaiBan(BanDangChon.Mabandangchon) && BanDangChon.Mabandangchon !=0)
            {
                frmThongTinHoaDon frm = new frmThongTinHoaDon();
                frm.ShowDialog();
             
           
            }
            else
            {
                MessageBox.Show("Bàn này đang trống không được xuất hóa đơn!", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);               
                              
            } 
            
            
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            qlban.CapNhatLaiTrangthaiBanDatTruoc(BanDangChon.Mabandangchon);
            MessageBox.Show("Đặt bàn thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKetCa_Click(object sender, EventArgs e)
        {
            if (hd.Ketca() == 0)
            {
                if(hd.demhoadon()==0)
                {
                    MessageBox.Show("Chưa có hóa đơn nào để kết ca");
                    return;
                }
                else
                {
                    frmKetCa frm = new frmKetCa();
                    frm.Show();
                }
              
            }
            else
            {
                MessageBox.Show("Vui lòng thanh toán tất cả các bàn còn lại trước khi kết ca");
                return;
            }
        }

        private void btnLoadLai_Click(object sender, EventArgs e)
        {
        
            tabControl.Controls.Clear();                  
            taoKhuVuc();
        }
    }
}
