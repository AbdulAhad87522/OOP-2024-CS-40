using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class BMW:Cars
    {
        private int distance;
        public int cfare()
        {
            int fare = 0;
            if (getmodel() < 2022)
            {
                if (distance < 10)
                {
                    fare = 1000 * distance;
                }
                else if (distance > 10 && distance < 50)
                {
                    fare = 900 * distance;
                }
                else if (distance > 50)
                {
                    fare = 700 * distance;
                }
            }
            else if(getmodel() > 2022 && getmodel() < 2024)
            {
                if (distance < 10)
                {
                    fare = 1100 * distance;
                }
                else if (distance > 10 && distance < 50)
                {
                    fare = 1000 * distance;
                }
                else if (distance > 50)
                {
                    fare = 800 * distance;
                }
            }
            else if (getmodel() > 2024 )
            {
                if (distance < 10)
                {
                    fare = 1300 * distance;
                }
                else if (distance > 10 && distance < 50)
                {
                    fare = 1050 * distance;
                }
                else if (distance > 50)
                {
                    fare = 1000 * distance;
                }
            }
            return fare;
        }
        public void setdistance(int distance)
        {
            this.distance = distance;
        }
        public int getdistance()
        {
            return distance;
        }
    }
}
