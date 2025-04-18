using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff s = new Staff();
            Student stu = new Student();
            s.setname("ahad");
            s.setaddress("dijkot");
            s.setachool("UET lahore");
            s.setpay(10000);
            Console.WriteLine(s.getname());
            Console.WriteLine(s.getaddress());
            Console.WriteLine(s.getpay());
            Console.WriteLine(s.getschool());
            stu.setname("gillani");
            stu.setaddress("faisalbad");
            stu.setprogram("computer science");
            stu.setyear(2005);
            stu.setfee(1000);
            Console.WriteLine(stu.getname());
            Console.WriteLine(stu.getaddress());
            Console.WriteLine(stu.getprogram());
            Console.WriteLine(stu.getyear());
            Console.WriteLine(stu.getfee());



        }
    }
}
