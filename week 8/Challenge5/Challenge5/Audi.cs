using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Audi:BMW
    {
        public new int cfare()
        {
            int fare = 0;
            if (getmodel() < 2022)
            {
                if (getdistance() < 10)
                {
                    fare = 1200 * getdistance();
                }
                else if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 1000 * getdistance();
                }
                else if (getdistance() > 50)
                {
                    fare = 800 * getdistance();
                }
            }
            else if (getmodel() > 2022 && getmodel() < 2024)
            {
                if (getdistance() < 10)
                {
                    fare = 1400 * getdistance();
                }
                else if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 1200 * getdistance();
                }
                else if (getdistance() > 50)
                {
                    fare = 1000 * getdistance();
                }
            }
            else if (getmodel() > 2024 )
            {
                if (getdistance() < 10)
                {
                    fare = 1500 * getdistance();
                }
                else if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 1399 * getdistance();
                }
                else if (getdistance() > 50)
                {
                    fare = 1200 * getdistance();
                }
            }
            return fare;
        }
    }
}
