using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Follower f = new Follower("ahad");
            Follower f1 = new Follower("Ali");
            Follower f2= new Follower("Usman");

            Post p = new Post("In the name of allah");
            p.addcomment("mashallah", true , f);
            p.addcomment("Nice", true, f1);
            p.addcomment("allah khair", true, f2);

            p.print();
        }
    }
}
