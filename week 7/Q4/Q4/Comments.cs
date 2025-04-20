using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Comments
    {
        public string compliment;
        public Comments() { }
        public Comments(string compliment)
        {
            this.compliment = compliment;
        }
        public void print()
        {
            Console.WriteLine(compliment);
        }
    }
}
