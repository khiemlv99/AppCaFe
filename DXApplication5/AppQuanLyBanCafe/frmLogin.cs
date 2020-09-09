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
    public partial class frmLogin : Form
    {
        PhanQuyen_BLL pq = new PhanQuyen_BLL();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
         
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '*';
            txtPassWord.Clear();   
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           

        }

        public void ProcessLogin()
        {
            QL_NguoiDung ql = new QL_NguoiDung();
            int result = ql.CheckUser(txtUsername.Text, txtPassWord.Text);   //Trong class QL_NguoiDung

            if (result == 99)
            {
                MessageBox.Show("Sai username hoặc password");
                return;
            }
            else {
                if (result == 101)
                {
                    
                    if (Program.frmMain == null || Program.frmMain.IsDisposed)
                    {
                        Program.frmMain = new frmMain();
                    }
                    this.Visible = false;
                    ThongTin.MaNhom1 = pq.GetMaNhom(txtUsername.Text);
                    Program.frmMain.Show();
                }
            }



        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            QL_NguoiDung ql = new QL_NguoiDung();
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống username");
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassWord.Text))
            {
                MessageBox.Show("Không được bỏ trống passwrod");
                this.txtPassWord.Focus();
                return;
            }

            int kq = ql.checkConfig(); // hàm check thuộc class QL_NguoiDung

            if (kq == 0)
            {

                ProcessLogin();


                //cấu hình phù hợp
            }

            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                Program.frmCapNhat = new frmCapNhatHeThong();
                Program.frmCapNhat.Show();
                //xử lý cấu hình (không tồn tại) 
            }

            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                Program.frmCapNhat = new frmCapNhatHeThong();
                Program.frmCapNhat.Show();
                //xử lý cấu hình (không phù hợp) 
            }

        }

        private void btnShut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                QL_NguoiDung ql = new QL_NguoiDung();
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống username");
                    this.txtUsername.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPassWord.Text))
                {
                    MessageBox.Show("Không được bỏ trống passwrod");
                    this.txtPassWord.Focus();
                    return;
                }

                int kq = ql.checkConfig(); // hàm check thuộc class QL_NguoiDung

                if (kq == 0)
                {

                    ProcessLogin();


                    //cấu hình phù hợp
                }

                if (kq == 1)
                {
                    MessageBox.Show("Chuỗi cấu hình không tồn tại");
                    Program.frmCapNhat = new frmCapNhatHeThong();
                    Program.frmCapNhat.Show();
                    //xử lý cấu hình (không tồn tại) 
                }

                if (kq == 2)
                {
                    MessageBox.Show("Chuỗi cấu hình không phù hợp");
                    Program.frmCapNhat = new frmCapNhatHeThong();
                    Program.frmCapNhat.Show();
                    //xử lý cấu hình (không phù hợp) 
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QL_NguoiDung ql = new QL_NguoiDung();
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống username");
                    this.txtUsername.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPassWord.Text))
                {
                    MessageBox.Show("Không được bỏ trống passwrod");
                    this.txtPassWord.Focus();
                    return;
                }

                int kq = ql.checkConfig(); // hàm check thuộc class QL_NguoiDung

                if (kq == 0)
                {

                    ProcessLogin();


                    //cấu hình phù hợp
                }

                if (kq == 1)
                {
                    MessageBox.Show("Chuỗi cấu hình không tồn tại");
                    Program.frmCapNhat = new frmCapNhatHeThong();
                    Program.frmCapNhat.Show();
                    //xử lý cấu hình (không tồn tại) 
                }

                if (kq == 2)
                {
                    MessageBox.Show("Chuỗi cấu hình không phù hợp");
                    Program.frmCapNhat = new frmCapNhatHeThong();
                    Program.frmCapNhat.Show();
                    //xử lý cấu hình (không phù hợp) 
                }
            }
        }
    }
}
