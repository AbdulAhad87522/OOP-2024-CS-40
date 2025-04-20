using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Like
    {
        public bool like;
        public Like()
        {
            
        }
        public Like(bool like)
        {
            this.like = like;
        }
        public void print()
        {
            if(like)
            {
                Console.WriteLine("Liked");
            }
            else
            {
                Console.WriteLine("Dislike");
            }
        }
    }
}
