using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ALL
{
    public class thucDon
    {
        public static string mamon, tenmon, DVT;

        public static string DVT1
        {
            get { return thucDon.DVT; }
            set { thucDon.DVT = value; }
        }

        public static string Tenmon
        {
            get { return thucDon.tenmon; }
            set { thucDon.tenmon = value; }
        }

        public static string Mamon
        {
            get { return thucDon.mamon; }
            set { thucDon.mamon = value; }
        }
        private static double gia;

        public static double Gia
        {
            get { return thucDon.gia; }
            set { thucDon.gia = value; }
        }
        private static Image hinhanh;

        public static Image Hinhanh
        {
            get { return thucDon.hinhanh; }
            set { thucDon.hinhanh = value; }
        }
        
    }
}
