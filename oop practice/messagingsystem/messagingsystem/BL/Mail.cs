using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagingsystem.BL
{
    internal class Mail
    {
        public string from;
        public string to;
        public string context;
        public Mail(string from , string to , string context)
        {
            this.from = from;
            this.to = to;
            this.context = context;
        }
        
    }
}
