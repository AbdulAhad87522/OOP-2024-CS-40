using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    internal class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Person()
        {

        }
        public string getname()
        {
            return name;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setaddress(string address)
        {
            this.address = address;
        }
        public string getaddress()
        {
            return address;
        }
    }
}
