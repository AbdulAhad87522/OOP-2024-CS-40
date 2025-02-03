using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            ATM atm = new ATM(balance);
            int option = input(balance);
            while (option != 4)
            {
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you wanna deposit");
                        int amount = int.Parse(Console.ReadLine());
                        atm.deposit( amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you wanna withdraw");
                        int amount_2 = int.Parse(Console.ReadLine());
                        atm.Withdrawl( amount_2);
                        break;
                    case 3:
                        int result = atm.Check_balance();
                        Console.WriteLine($"total amount in your account is: {result}");
                        Console.ReadKey();
                        break;
                }
                option = input(balance);
            }
        }
        public static int input(int amount)
        {
            Console.WriteLine("1.Deposit amonut.");
            Console.WriteLine("2.withdraw amonut.");
            Console.WriteLine("3.check amonut.");
            Console.WriteLine("Enter your option: ");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
    }
}
