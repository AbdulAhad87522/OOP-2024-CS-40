using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Car
    {
        public eNGINE Engine;
        public Car(eNGINE engine)
        {
            Engine = engine;
        }
        public void Crush()
        {
            Console.WriteLine($"The car is crashed and {Engine.type}");
        }
    }
}
