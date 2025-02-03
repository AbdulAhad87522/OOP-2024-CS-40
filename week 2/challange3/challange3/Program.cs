using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace challange3
{
    internal class Program
    {
        static List<Page> array = new List<Page>();
        static void Main(string[] args)
        {
            Page sign = new Page();

            int option = Menu();
            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        signup();
                        break;
                    case 2:
                        signin();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option entered.");
                        break;
                }
                option = Menu();
            }
        }
        public static int Menu()
        {
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Sign in");
            Console.WriteLine("3.Exit.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void signup()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role: ");
            string role = Console.ReadLine();
            Page sign = new Page(name, password, role);
            array.Add(sign);
        }
        public static void signin()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            foreach (Page page in array)
            {
                if((page.Username == name) && (page.Password == password))
                {
                    Console.WriteLine($"you have signed in as {page.Role}");
                }
                else
                {
                    Console.WriteLine("Invalid credentials entered ");
                    Console.WriteLine("Please sign up first.");
                }
            }
        }
    }
    class Page
    {
        public string Username;
        public string Password;
        public string Role;

        public Page()
        {
        }

        public Page(string name , string password , string role)
        {
            Username = name;
            Password = password;
            Role = role;
        }
    }
}
