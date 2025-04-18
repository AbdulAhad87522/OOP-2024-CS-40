using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poultryform
{
    internal class Users
    {
        protected string name;
        private string password;
        public Users(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Users(string name)
        {
            this.name = name;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public string getpassword()
        {
            return this.password;
        }
    }
}
