using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using messagingsystem.UI;
using messagingsystem.BL;
using messagingsystem.DL;

namespace messagingsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Userdata user = new Userdata();
            Maildata data = new Maildata();
            Muser uss = new Muser();
            int option = Menu();
            while (option != 5)
            {
                switch(option)
                {
                    case 1:
                        //add user 
                        Muser users = UserUI.getuserinfo();
                        user.adduser(users);
                        uss.adduser();
                        getkey();
                        break;
                    case 2:
                        // show users\
                        List<Muser> use = user.getall();    
                        UserUI.showall(use);
                        getkey();
                        break;
                    case 3:
                        //send a message
                        Mail mail = mailUI.generatemail();
                        data.addmail(mail);
                        getkey();
                        break;
                    case 4:
                        //show all messages
                        Console.WriteLine("Enter the name: ");
                        String username = Console.ReadLine();
                        List<Mail> mails = data.geta_specific_mail(username);
                        mailUI.showallmessages(mails);
                        getkey();
                        break;
                }
                option = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("1.Add user.");
            Console.WriteLine("2.Show all.");
            Console.WriteLine("3.Send messages.");
            Console.WriteLine("4.show all mesages.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void getkey()
        {
            Console.WriteLine("Enter any key to continue.");
            Console.ReadKey();
        }
    }
}
