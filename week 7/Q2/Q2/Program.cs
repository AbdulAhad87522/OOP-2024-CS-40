using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs play = new Songs("295");
            play.addsongs("Sidhu moose wala");
            play.addsongs("Shout out big bird.");
            play.print();
            
        }
    }
}
