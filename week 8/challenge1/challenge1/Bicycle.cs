using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Bicycle
    {
        public int cadence;
        public int gear;
        public int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setcadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setgear(int gear)
        {
            this.gear = gear;
        }
        public void applybrakes(int decrement)
        {
            speed = speed - decrement;
        }
        public void speedup(int increment)
        {
            speed = speed + increment;
        }
    }
}
