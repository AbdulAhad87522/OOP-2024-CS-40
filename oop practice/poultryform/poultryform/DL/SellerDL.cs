using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using poultryform.BL;

namespace poultryform.DL
{
    internal class SellerDL
    {
        public static List<Seller> seller = new List<Seller>();
        public static void adduser(Seller s)
        {
            seller.Add(s);
        }
        public static bool checkseller(string name)
        {
            foreach(Seller s in seller)
            {
                if(s.getname() == name) return true;
            }
            return false;
        }
        public static List<Seller> getsellerlist()
        {
            return seller;
        }

    }
}
