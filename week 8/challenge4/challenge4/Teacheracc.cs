using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Teacheracc : account
    {
        public const int acclimit = 1000000;
        public Teacheracc(string accnumber, string accmunber, double balance) : base(accnumber, accmunber, balance)
        {

        }
        public void Withdraw(double amount)
        {
            if (amount < acclimit && amount < 0)
            {
                balance -= amount;
                Console.WriteLine($"Withrawn amount : {amount}  ,  Remaining balance : {balance}");
            }
            else
            {
                Console.WriteLine("You have exceed the limit .");
            }
        }
        public void deposited(double amount)
        {
            if (amount < acclimit && amount < 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited amount : {amount}  ,  Total balance : {balance}");
            }
            else
            {
                Console.WriteLine("You have exceed the limit .");
            }
        }
    }
}