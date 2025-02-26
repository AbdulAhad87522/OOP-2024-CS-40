using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfassessment_UAMS_.DL;

namespace selfassessment_UAMS_.BL
{
    internal class degreeprogram
    {
        public string title;
        public string duration;
        int seats;
        public static List<subject> subjects;
        public degreeprogram(string title , string duration,int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<subject>();
        }
    }
}
