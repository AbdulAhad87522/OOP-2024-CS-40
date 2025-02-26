using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace challange_2
{
    internal class Program
    {
       static List<User>members = new List<User>();
        static void Main(string[] args)
        {
            int option = Menu();
            while (option != 7)
            {
                switch (option)
                {
                    case 1:
                        add_member();
                        break;
                    case 2:
                        update_member();
                        break;
                    case 3:
                        showbooks();
                        break;
                    case 4:
                        spent_amount();
                        break;
                    case 5:
                        Delete();
                        break;
                    case 6:
                        showmembers();
                        break;
                }
                option = Menu();
            }
        }
        static int Menu()
        {
            Console.WriteLine("1.Add member.");
            Console.WriteLine("2.update member.");
            Console.WriteLine("3.number of books bought.");
            Console.WriteLine("4.amount spent by each member");
            Console.WriteLine("5.delete member.");
            Console.WriteLine("6.Show all members.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void add_member()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the member ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of books brought: ");
            int books = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the money in the bank");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount spent: ");
            int spent = int.Parse(Console.ReadLine());
             User member = new User( name, ID, books, money, spent);
            members.Add(member);
        }
        static void update_member()
        {
            Console.WriteLine("Enter the member ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the updated number pf books: ");
            int books = int.Parse(Console.ReadLine());
            foreach(User member in members)
            {
                if(member.memberID == ID)
                {
                    member.number_of_books_brought = books;
                    member.Name = name;
                }
            }
        }
        static void showbooks()
        {
            Console.WriteLine("Enter the Id of the member: ");
            int ID = int.Parse(Console.ReadLine());
            foreach(User member in members)
            {
                if(member.memberID == ID)
                {
                    Console.WriteLine($"The number of books brought by {member.number_of_books_brought}");
                }
            }
        }
        static void spent_amount()
        {
            Console.WriteLine("Enter the ID of the member: ");
            int ID = int.Parse(Console.ReadLine());
            foreach(User member in members)
            {
                if(member.memberID == ID)
                {
                    Console.WriteLine($"Amount spent by {member.Name} is {member.money_out_bank}");
                }
            }
        }
        static void Delete()
        {
            Console.WriteLine("ENTER THE MEMBER'S ID :");
            int id = int.Parse(Console.ReadLine());
            foreach (User member in members)
            {
                if(member.memberID == id)
                {
                    members.Remove(member);
                }
            }
        }
        static void showmembers()
        {
            foreach(User member in members)
            {
                    Console.WriteLine($"Name : {member.Name} , Member Id : {member.memberID} , Books brought: {member.number_of_books_brought}");
            }
        }
    }
}
