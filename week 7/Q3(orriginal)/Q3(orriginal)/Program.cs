using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Q3_orriginal_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sets s1 = new Sets();
            Sets s2 = new Sets();
            s1.weight = 10;
            s1.repitition = 3;
            s2.weight = 20;
            s2.repitition = 4;
            Routine r = new Routine("monday");
            r.addexercise("squat", s1);
            r.addexercise("squat", s2);
            r.print();
        }
    }
}
