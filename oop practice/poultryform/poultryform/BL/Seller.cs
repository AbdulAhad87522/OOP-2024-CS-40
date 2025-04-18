using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace poultryform.BL
{
    internal class Seller : Inventory
    {
        private string name; 
        private long phone;
        private long CNIC;
        private string address;
        public Seller(string name, long phone, long CNIC, string address , int chicks , int died_chicks , int weight , DateTime date , int price) : base(chicks , died_chicks , weight , date , price)
        {
            this.name = name;
            this.phone = phone;
            this.CNIC = CNIC;
            this.address = address;
        }
        public Seller(string name, long phone, string address,  DateTime date, int price ,int weight) : base(weight, date, price)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
        public Seller()
        {

        }
        public Seller(string name, long phone, long cNIC, string address)
        {
            this.name = name;
            this.phone = phone;
            CNIC = cNIC;
            this.address = address;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public void setphone(long phone)
        {
            this.phone = phone;
        }
        public long getphone()
        {
            return phone;
        }
        public void setcnic(long cnic)
        {
            this.CNIC = cnic;
        }
        public long getcnic()
        {
            return CNIC;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }
        public string getaddress()
        {
            return address;
        }
    }
}
