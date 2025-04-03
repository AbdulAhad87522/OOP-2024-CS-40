using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using mailsystem2.BL;
using mailsystem2.DL;
using mailsystem2.UI;


namespace mailsystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mailBL mails = new mailBL();
            MuserDL userdata = new MuserDL();
            mailDL mailDL = new mailDL();
            int option = Menu();
            while(option != 5)
            {
                switch (option)
                {
                    case 1:
                        MuserBL user = MuserUI.getuserinfo();
                        userdata.adduser(user);
                        waitKey();
                        break;
                    case 2:
                        List<MuserBL> users = userdata.getUser();
                        MuserUI.showusers(users);
                        waitKey();
                        break;
                    case 3:
                        mailBL mail = mailUI.frontend();
                        mailDL.addmail(mail);
                        waitKey();
                        break;
                    case 4:
                        Console.Write("ENTER YOUR NAME (to which message is sent): ");
                        string name = Console.ReadLine();
                        List<mailBL> maild = mailDL.getmails(name);
                        List<mailBL> filteredmails = maild.Where(mailv => mailv.to == name).ToList();
                        if (filteredmails.Count >0)
                        {
                            mailUI.showmails(maild);
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                        waitKey();
                        break;
                }
                option = Menu();

            }

        }
        public static int Menu()
        {
            Console.WriteLine("1.Sighn up ");
            Console.WriteLine("2.Show all");
            Console.WriteLine("3.Send a message ");
            Console.WriteLine("4.Check message.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void waitKey()
        {
            Console.WriteLine("Press any Key to Continue...");
            Console.ReadKey();
        }
    }
}
