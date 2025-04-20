using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Animal
    {
        private string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public virtual string tostring()
        {
            return $"Animal[name= {name}]";
        }
    }
}
