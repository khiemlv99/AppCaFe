using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ALL
{
    public class ThongTin
    {
        private static string MaNhom;

        public static string MaNhom1
        {
            get { return ThongTin.MaNhom; }
            set { ThongTin.MaNhom = value; }
        }
    }
}
