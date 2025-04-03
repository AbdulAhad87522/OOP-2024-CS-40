using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mailsystem2.BL;
namespace mailsystem2.DL
{
    internal class mailDL
    {
        public List<mailBL> mails = new List<mailBL>();
        public void addmail(mailBL mai)
        {
            mails.Add(mai);
        }
        public List<mailBL> getmails(string username)
        {
            return mails.FindAll(mails => mails.to == username);
        }
    }
}
