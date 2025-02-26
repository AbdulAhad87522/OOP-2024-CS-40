using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment_UAMS_.BL
{
    internal class subject
    {
        public string code;
        public int credithours;
        public string subjecttype;
        public int subjectfee;
        public subject(string code , int credithours , string subjecttype , int subjectfee)
        {
            this.code = code;
            this.credithours = credithours;
            this.subjecttype = subjecttype;
            this.subjectfee = subjectfee;
        }
    }
}
