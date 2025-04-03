using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mailsystem2.BL;

namespace mailsystem2.UI
{
    internal class mailUI
    {
        public static mailBL frontend()
        {
            Console.Write("From : ");
            string from = Console.ReadLine();  
            Console.Write("To : ");
            string to = Console.ReadLine();
            Console.WriteLine("Subject : ");
            string subject = Console.ReadLine();
            mailBL mail = new mailBL(from , to , subject);
            return mail;
        }
        public static void showmails(List<mailBL> mail)
        {
            foreach (mailBL mails in mail)
            {
                    Console.WriteLine($"From : {mails.from} , Subject : {mails.subject}");
            }
        }
    }
}
