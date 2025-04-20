using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_orriginal_
{
    internal class Routine//composition with exercise
    {
        public string name;
        public List<Exercises> exercises;
        public Routine(string name)
        {
            this.name = name;
            exercises = new List<Exercises>();
        }
        public  void addexercise(string name,Sets s)
        {
            Exercises ex = new Exercises(name);
            exercises.Add(ex);
            ex.addset(s);
        }
        public void print()
        {
            Console.WriteLine($"The exercise for the day of: {name}");
            foreach(Exercises e in exercises)
            {
                e.print();
            }
        }
    }
}
