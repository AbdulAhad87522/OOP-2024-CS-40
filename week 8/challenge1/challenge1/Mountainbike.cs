using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Mountainbike : Bicycle
    {
        public int seatheight;
        
        public Mountainbike(int cadence, int gear, int speed) : base(cadence, gear, speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
      
        
        public void setseatheight(int height)
        {
            seatheight = height;
        }
    }
}
