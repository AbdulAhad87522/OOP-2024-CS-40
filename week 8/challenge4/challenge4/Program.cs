using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = Menu();
            while (option != 3)
            {
                if (option == 1)
                {
                    Console.WriteLine("You have selected student acount.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter the account title");
                    string account_number = Console.ReadLine();
                    Console.Write("Enter the account number: ");
                    string account_title = Console.ReadLine();
                    Console.Write("Enter the balance: ");
                    double balance = double.Parse(Console.ReadLine());
                    Studentacc acount = new Studentacc(account_number, account_title , balance);

                }
                else if (option == 2)
                {
                    Console.WriteLine("You have selected teacher account.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter the account title");
                    string account_numbe = Console.ReadLine();
                    Console.Write("Enter the account number: ");
                    string account_titl = Console.ReadLine();
                    Console.Write("Enter the balance: ");
                    double balanc = double.Parse(Console.ReadLine());
                    Teacheracc account = new Teacheracc(account_numbe , account_titl , balanc);

                }
                option = Menu();
            }
        }
        public static int Menu()
        {
            Console.WriteLine("1. Student account.");
            Console.WriteLine("2. Teacher account.");

            Console.WriteLine("3. Exit.");
            Console.WriteLine("Enter your option");
            int option = int.Parse(Console.ReadLine());
            return option;


        }
    }
}
