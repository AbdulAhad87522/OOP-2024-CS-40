using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using messagingsystem.BL;

namespace messagingsystem.DL
{
    internal class Maildata
    {
       List<Mail> store = new List<Mail> ();
    public void addmail(Mail mail)
        {
            store.Add(mail);
        }
        public List<Mail> geta_specific_mail(string username)
        {
            return store.FindAll(mail => mail.from == username);
        }
    }
}
