using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class account
    {
        public string account_title;
        public string account_number;
        public double balance;
        public account() { }
        public account(string account_title, string account_number, double balance)
        {
            this.account_title = account_title;
            this.account_number = account_number;
            this.balance = balance;
        }    }
}
