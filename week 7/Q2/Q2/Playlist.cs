using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Playlist
    {
        private string content;
        public Playlist(string content)
        {
            this.content = content;
        }
        public  void print()
        {
            Console.WriteLine(content);
        }
    }
}   
