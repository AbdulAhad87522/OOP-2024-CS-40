using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfassessment_UAMS_.BL;


namespace selfassessment_UAMS_.DL
{
    internal class studentDL
    {
        List<student> studentdata = new List<student>();
        public List<student> getall()
        {
            return studentdata;
        }
    }
}
