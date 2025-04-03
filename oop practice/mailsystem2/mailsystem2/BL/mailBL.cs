using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailsystem2.BL
{
    internal class mailBL
    {
        public string from;
        public string to;
        public string subject;
        public mailBL(string from , string to , string subject)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
        }
        public mailBL()
        {

        }
    }

}
