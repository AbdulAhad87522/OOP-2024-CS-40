using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class GLI:BMW
    {
        public new int cfare ()
        {
            int fare = 0;
            if (getmodel() < 2022)
            {
                if (getdistance() < 10)
                {
                    fare = 500 * getdistance();
                }
                if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 400 * getdistance();
                }
                if (getdistance() > 50)
                {
                    fare = 300 * getdistance();
                }
            }
            if(getmodel() > 2022 && getmodel() < 2024)
            {
                if (getdistance() < 10)
                {
                    fare = 600 * getdistance();
                }
                if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 500 * getdistance();
                }
                if (getdistance() > 50)
                {
                    fare = 400 * getdistance();
                }
            }
            if (getmodel() > 2024)
            {
                if (getdistance() < 10)
                {
                    fare = 700 * getdistance();
                }
                if (getdistance() > 10 && getdistance() < 50)
                {
                    fare = 600 * getdistance();
                }
                if (getdistance() > 50)
                {
                    fare = 500 * getdistance();
                }
            }
            return fare;
        }
    }
}
