using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static List<Student>students = new List<Student>();
        static List<Degree_program>degree = new List<Degree_program>();
        static void Main(string[] args)
        {
            int option = Menu();
            while(option != 8)
            {
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your markss in Fsc: ");
                        double fsc_marks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your marks in matric: ");
                        double matric_marks = int.Parse(Console.ReadLine());
                        Student student = new Student(name, age, fsc_marks, matric_marks);
                        students.Add(student);
                        break;
                    case 2:
                        Console.WriteLine("Enter degree name: ");
                        string degree_name = Console.ReadLine();
                        Console.WriteLine("Enter degree duratiion: ");
                        int duration = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter seats for degree: ");
                        int seats = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter how many subjectsto enter: ");
                        int no_of_subject= int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter subject code: ");
                        string sub_code = Console.ReadLine();
                        Console.WriteLine("Enter dunject type: ");
                        string sub_type =  Console.ReadLine();
                        Console.WriteLine("Enter credit hours: ");
                        int credit_hours = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter subject fees: ");
                        int sub_fees = int.Parse(Console.ReadLine());
                        Degree_program degree_program = new Degree_program(degree_name, duration, seats, no_of_subject, sub_code, sub_type, credit_hours, sub_fees);
                        degree.Add(degree_program);
                        break;
                    case 3://generate merit 
                        foreach (Student s in students)
                        {
                            Console.WriteLine($"Name: {s.Name}  , FSC: {s.FSC_Marks} , matric: {s.Matric_Marks} , aggregate: {s.aggree}");
                        }
                        break;
                    case 4:
                        foreach (Student s in students)
                        {
                            Console.WriteLine($"Name: {s.Name}  , FSC: {s.FSC_Marks} , matric: {s.Matric_Marks}");
                        }
                        break;

                }
                option = Menu();
            }
        }
        static int Menu()
        {
            Console.WriteLine("1.Add Student.");
            Console.WriteLine("2.Add degree program.");
            Console.WriteLine("3.generate merit list.");
            Console.WriteLine("4.View registered students.");
            Console.WriteLine("5.view students of Program.");
            Console.WriteLine("6.Register subjects for a specific students.");
            Console.WriteLine("7.Calculate fees for all registered students.");
            Console.WriteLine("8.Exit.");
            Console.WriteLine("Enter your option: ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

    }
}
