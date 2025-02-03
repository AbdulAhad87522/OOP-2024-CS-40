using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace challange_1
{
    internal class Program
    {
          static  List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            int option = Menu();
            while(option != 5)
            {
                switch(option)
                {
                    case 1:
                        Addstudent();
                        break;
                    case 2:
                        showstudents();
                        break;
                    case 3:
                        aggregate();
                        break;
                    case 4:
                        Showtopstudents();
                        break;
                }
                option = Menu();
            }
        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Add student.");
            Console.WriteLine("2.Show students.");
            Console.WriteLine("3.Calculate aggregate.");
            Console.WriteLine("4.Top student..");
            Console.Write("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static void Addstudent()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your marks in matric: ");
            double matricmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in Fsc: ");
            double fscmarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your marks in ECAT: ");
            double ecatmarks = double.Parse(Console.ReadLine());
            Student newstudent = new Student(name,matricmarks, fscmarks, ecatmarks);
            students.Add(newstudent);
        }
        static void showstudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students registered.");
                Console.ReadKey();
            }
            else
            {
                foreach (Student student in students)
                {
                    student.ShowStudent();
                }
            }
        }
        static void aggregate()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            else

            {
               foreach(Student student in students)
                {
                    student.Calculateaggregate();
                    Console.WriteLine($"name: {student.Name} , aggregate :{student.Aggregate:F3}%");
                }
            }
        }
        static void Showtopstudents()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No students found.");
            }
            var topstudents = new List<Student>(students);
            topstudents.Sort((s1,s2) => s2.Aggregate.CompareTo(s1.Aggregate));
                Console.WriteLine("Top 3 students are as follows: ");
            for (int i = 0; i < Math.Min(3 , topstudents.Count); i++)

            {
                topstudents[i].ShowStudent();
            }
            Console.ReadKey();
        }
    }
}
