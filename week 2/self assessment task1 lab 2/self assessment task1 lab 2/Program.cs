using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assessment_task1_lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction();        
        }
        class Transaction
        {
            public Transaction()
            {
                

            }
            public string TransactionID;
            public string ProductName;
            public string Amount;
            public DateTime Transaction_date;   
            public Transaction(Transaction transaction)
            {
                TransactionID = transaction.TransactionID;
                ProductName = transaction.ProductName;
                Amount = transaction.Amount;
                Transaction_date = transaction.Transaction_date;
            }
        }
    }
}
