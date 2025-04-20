using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Follower
    {
        public string ID;
        public Follower()
        {

        }
        public Follower(string ID)
        {
            this.ID = ID;
        }
        public void print()
        {
            Console.WriteLine($"ID: {ID}");
        }
    }
}
