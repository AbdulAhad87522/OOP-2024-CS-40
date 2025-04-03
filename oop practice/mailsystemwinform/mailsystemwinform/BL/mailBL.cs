using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailsystemwinform.BL
{
    public class mailBL
    {
        public string from;
        public string to;
        public string contents;

        public mailBL(string from, string to, string contents)
        {
            this.from = from;
            this.to = to;
            this.contents = contents;
        }
    }
}
