using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace BLL_ALL
{
    public class QL_NguoiDung
    {
        public int checkConfig()
        {
            if (Properties.Settings.Default.MyPham == string.Empty)
            {
                return 1;// cấu hình không tồn tại
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.MyPham);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return 0;// kết nối thành công
            }
            catch
            {
                return 2; //Chuỗi cấu hình không phù hợp
            }
        }

        public int CheckUser(string user, string pass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from TaiKhoan Where TenTaiKhoan='" + user
                + "' and MatKhau='" + pass + "'"
                , Properties.Settings.Default.MyPham);

            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 99;//User không tồn tại          
            return 101;//Đăng nhập thành công 

        }

        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDatabaseName(string pSever, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            string sql = "select name from sys.Databases";
            SqlDataAdapter da = new SqlDataAdapter(sql, "Data Source ='" + pSever
                + "';Initial Catalog=master;Integrated Security=true");
            da.Fill(dt);
            return dt;
        }

        public void SaveConfig(string pServer, string pDBname)
        {
            BLL_ALL.Properties.Settings.Default.MyPham = "Data Source=" + pServer +
                                                       ";Initial Catalog=" + pDBname + ";Integrated Security=true";
            BLL_ALL.Properties.Settings.Default.Save();
        }
    }
}
