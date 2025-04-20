using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("billi");
            Cat c1 = new Cat("billa");
            Dog d = new Dog("kutta");
            Dog d1 = new Dog("phir kutta");
            d.greet(d1);
            d.greet();
        }
    }
}
