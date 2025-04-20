using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eNGINE e = new eNGINE("v6 turbo");
            Car c = new Car(e);
            c.Crush();
        }
    }
}
