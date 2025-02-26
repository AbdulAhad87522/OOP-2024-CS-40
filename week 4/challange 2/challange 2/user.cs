using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace challange_2
{
    internal class User
    {
        public string Name;
        public int memberID;
        public int number_of_books_brought;
        public int money_in_bank;
        public int money_out_bank;
        public User(string name ,int ID ,int books ,int money ,int spent)
        {
            Name = name;
            memberID = ID;
            number_of_books_brought = books;
            money_in_bank = money;
            money_out_bank = spent;
        }
    }
}
