using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mailsystem2.BL;

namespace mailsystem2.DL
{
    internal class MuserDL
    {
        public List<MuserBL> users = new List<MuserBL>();
        public void adduser(MuserBL user)
        {
            users.Add(user);
        }
        public List<MuserBL> getUser()
        {
            return users;
        }
    }
}
