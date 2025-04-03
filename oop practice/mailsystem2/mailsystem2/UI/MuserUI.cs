using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mailsystem2.BL;

namespace mailsystem2.UI
{
    internal class MuserUI
    {
       public static MuserBL getuserinfo()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter tyhe password : ");
            string password = Console.ReadLine();
            MuserBL user = new MuserBL(name , password);
            return user;
        }
        public static void showusers(List<MuserBL> user)
        {
            foreach (MuserBL users in user)
            { 
            Console.WriteLine($"Name : {users.name} , Password : {users.password}");
            }
        }
    }   
}
