using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using messagingsystem.BL;



namespace messagingsystem.DL
{
    internal class Userdata
    {
        public List<Muser> users =new List<Muser> ();
        public  void adduser(Muser user)
        {
            users.Add(user);
        }
        public List<Muser> getall()
        {
            return users;
        }
    }
}
