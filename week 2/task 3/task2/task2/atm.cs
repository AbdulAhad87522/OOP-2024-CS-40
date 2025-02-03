using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class ATM
    {            
        public ATM(int balance)
            {
            Balance = balance;
            }
        public   int Balance ;
        public  void deposit( int amount)
        {
            Balance += amount;
        }
        public void Withdrawl( int amount)
        {
            Balance -= amount;
        }
        public int Check_balance()
        {
            return Balance;
        }
    }
}
