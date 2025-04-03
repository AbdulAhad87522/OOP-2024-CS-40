using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailsystemwinform.BL
{
    internal class MuserBL
    {
        public string name;
        public string password;
        public MuserBL(string name , string password) 
        {
            this.name = name;
            this.password = password;
        }
    }
}
