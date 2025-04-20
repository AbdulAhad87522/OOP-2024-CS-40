using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Audi a = new Audi();
            BMW b = new BMW();
            GLI g = new GLI();
            a.setcolor("red");
            a.setmodel(2025);
            a.setdistance(20);
            a.setprice(1000000);

            b.setcolor("green");
            b.setmodel(2025);
            b.setdistance(30);
            b.setprice(5000000);

            g.setcolor("blue");
            g.setmodel(2025);
            g.setdistance(30);
            g.setprice(2000000000);
            Console.WriteLine($"The total fare of audi would be: {a.cfare()}");
            Console.WriteLine($"The total fare of BMW would be: {b.cfare()}");
            Console.WriteLine($"The total fare of GLI would be: {g.cfare()}");

        }
    }
}
