using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        
        }
        public override string ToString()
        {
            return $"Mammal[{base.ToString()}]";
        }
    }
}
