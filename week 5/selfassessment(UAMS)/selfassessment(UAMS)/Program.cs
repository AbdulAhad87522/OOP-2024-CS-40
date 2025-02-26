using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfassessment_UAMS_.BL;
using selfassessment_UAMS_.DL;
using selfassessment_UAMS_.UI;

namespace selfassessment_UAMS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            degreeprogramDL degree= new degreeprogramDL();
            studentDL studentdata = new studentDL();
            subjectDL subjectdata = new subjectDL();
            int option = Menu();
            while(option!= 8)
            {
                switch(option)
                {
                    case 1:
                        student s = studentUI.addstudent();
                        studentdata.Add(s);
                        break;
                }
                option = Menu();
            }
        }
        static int Menu()
        {
            Console.WriteLine("1.Add student.");
            Console.WriteLine("2.Add degree program.");
            Console.WriteLine("3.Generate merit.");
            Console.WriteLine("4.View registered students.");
            Console.WriteLine("5.View students of a specific program.");
            Console.WriteLine("6.register student for specific subject.");
            Console.WriteLine("7.Calculate fee of registered students.");
            Console.WriteLine("Enter your option: ");
            int option = int .Parse(Console.ReadLine());
            return option;
        }
    }
}
