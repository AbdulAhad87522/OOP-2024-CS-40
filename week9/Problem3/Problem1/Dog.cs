using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Dog:Mammal
    {
        public Dog(string name):base(name) { }
        public void greet()
        {
            Console.WriteLine("Woof");
        }
        public void greet(Dog d)
        {
            Console.WriteLine("woooof");
        }
        public override string tostring()
        {
            return $"Dog[{base.tostring()}]";
        }
    }
}
