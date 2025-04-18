using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Studentacc : account
    {
        public const double acclimit = 500000;
        public Studentacc(string accnumber , string acctitle , double balance) : base(accnumber , acctitle ,  balance)
        {

        }
        public void DEBIT(double amount)
        {
            if(amount > 0 && amount < acclimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn amount: {amount}  , Remaining amount: {balance}");
            }
            else
            {
               Console.WriteLine(" account limit excced the required limit");
            }
        }
        public void CREDIT(double amount)
        {
            if (amount > 0 && amount < acclimit)
            {
                balance += amount;
                Console.WriteLine($"Deposited amount: {amount}  , Total amount: {balance}");
            }
            else
            {
                Console.WriteLine(" account limit excced the required limit");
            }
        }
    }
}
