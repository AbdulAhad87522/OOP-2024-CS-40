using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poultryform
{
    internal class UsersDL
    {
        public static List<Users> users = new List<Users>();
        public static void adduser(Users user)
        {
            users.Add(user);
        }
        public static bool checkuser(string name , string password)
        {
            foreach (Users user in users)
            {
                if(user.getname() == name && user.getpassword() == password)
                {
                    return true;
                }                
            }
            return false;
        }
    }
}
