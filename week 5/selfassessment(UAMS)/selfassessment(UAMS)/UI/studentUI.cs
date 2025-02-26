using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using selfassessment_UAMS_.BL;

namespace selfassessment_UAMS_.UI
{
    internal class studentUI
    {
        public static student addstudent()
        {
            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc marks:");
            double fscmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter matric marks: ");
            double matricmarks = double.Parse(Console.ReadLine());
            student user = new student(name , age , fscmarks , matricmarks);
            return user;
        }

        public void showwall(List<student> students)
        {
            foreach (student student in students)
            {
                Console.WriteLine("{0},{1},{2},{3}" , student.name , student.FSCmarks , student.ECATmarks , student.age);
            }
        }
    }
}
