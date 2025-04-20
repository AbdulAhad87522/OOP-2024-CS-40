using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public void greet()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return $"Cat[{base.tostring()}]";
        }
    }
}
