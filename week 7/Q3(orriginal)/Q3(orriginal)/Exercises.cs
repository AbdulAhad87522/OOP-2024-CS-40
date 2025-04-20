using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_orriginal_
{
    internal class Exercises
    {
        public string name;
        public List<Sets> sets;
        public Exercises(string name)
        {
            this.name = name;
            sets = new List<Sets>();
        }
        public void addset(Sets s)
        {
            sets.Add(s);
        }
        public void print()
        {
            Console.WriteLine($"Exercise: {name}");
            Console.WriteLine(" ");
            foreach (Sets s in sets)
            {
               
                Console.WriteLine($"weight: { s.weight}");
                Console.WriteLine($"Repitition: {s.repitition}");
            }
        }
    }
}
