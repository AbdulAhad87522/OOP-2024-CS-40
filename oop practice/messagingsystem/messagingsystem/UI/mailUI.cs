using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using messagingsystem.BL;

namespace messagingsystem.UI
{
    internal class mailUI
    {
        public static  Mail generatemail()
        {
            Console.WriteLine("Enter your name: ");
            string from = Console.ReadLine();
            Console.WriteLine("Enter the name of reciever: ");
            string to = Console.ReadLine();
            Console.WriteLine("Enter the context: ");
            string context = Console.ReadLine();
            Mail mail = new Mail(from, to, context);
            return mail;
        }
        public static void showallmessages(List<Mail> mails)
        {
            foreach(Mail mail in mails)
            Console.WriteLine("{0} : {1}" , mail.to , mail.context);
        }
    }
}
