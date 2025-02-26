using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using messagingsystem.BL;
using System.Xml.Linq;

namespace messagingsystem.UI
{
    internal class UserUI
    {
        public static Muser getuserinfo()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Muser user = new Muser(name, password);
            return user;
        }

        public static void showall(List<Muser> users)
        {
            foreach(Muser user in users)
            {
                Console.WriteLine("{0} \t {1}" , user.name , user.password);
            }
        }
    }
}
