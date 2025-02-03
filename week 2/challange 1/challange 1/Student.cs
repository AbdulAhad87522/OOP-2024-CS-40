using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange_1
{
    internal class Student
    {
        public string Name;
        public double Matricmarks;
        public double FSCmarks;
        public double Ecatmarks;
        public double Aggregate;
        public Student (string name, double matricmarks, double fscmarks, double ecatmarks)
        {
            Name = name;
            Matricmarks = matricmarks;
            FSCmarks = fscmarks;
            Ecatmarks = ecatmarks;
            Calculateaggregate();
        }   
        public void Calculateaggregate()
        {
            Aggregate = (Matricmarks / 1100) * 30 + (FSCmarks / 1100) * 50 + (Ecatmarks / 400) * 20;
        }
        public void ShowStudent()
        {
            Console.WriteLine($"Name: {Name} ,  Matric : {Matricmarks} , Fsc marks : {FSCmarks} , Ecat marks: {Ecatmarks} , Aggregate : {Aggregate}");
        }
    }
}
//using System;
//using System.Collections.Generic;

//namespace StudentManagementSystem
//{
//    class Student
//    {
//        // Properties of a Student
//        public string Name { get; set; }
//        public double MatricMarks { get; set; } // Out of 1100
//        public double FscMarks { get; set; }    // Out of 1100
//        public double EcatMarks { get; set; }   // Out of 400
//        public double Aggregate { get; private set; } // Calculated aggregate

//        // Constructor
//        public Student(string name, double matricMarks, double fscMarks, double ecatMarks)
//        {
//            Name = name;
//            MatricMarks = matricMarks;
//            FscMarks = fscMarks;
//            EcatMarks = ecatMarks;
//            CalculateAggregate();
//        }

//        // Method to Calculate Aggregate
//        public void CalculateAggregate()
//        {
//            Aggregate = (MatricMarks / 1100) * 30 + (FscMarks / 1100) * 50 + (EcatMarks / 400) * 20;
//        }

//        // Display Student Details
//        public void ShowStudent()
//        {
//            Console.WriteLine($"Name: {Name}, Matric: {MatricMarks}, Fsc: {FscMarks}, ECAT: {EcatMarks}, Aggregate: {Aggregate:F2}%");
//        }
//    }

//    class Program
//    {
//        static List<Student> students = new List<Student>(); // List to store students

//        static void Main(string[] args)
//        {
//            int choice;
//            do
//            {
//                choice = ShowMenu();
//                switch (choice)
//                {
//                    case 1:
//                        AddStudent();
//                        break;
//                    case 2:
//                        ShowStudents();
//                        break;
//                    case 3:
//                        CalculateAggregates();
//                        break;
//                    case 4:
//                        ShowTopStudents();
//                        break;
//                    case 5:
//                        Console.WriteLine("Exiting program...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }
//                Console.WriteLine("\nPress any key to continue...");
//                Console.ReadKey();
//            } while (choice != 5);
//        }

//        // Show Menu
//        static int ShowMenu()
//        {
//            Console.Clear();
//            Console.WriteLine("Student Management System");
//            Console.WriteLine("1. Add Student");
//            Console.WriteLine("2. Show Students");
//            Console.WriteLine("3. Calculate Aggregate");
//            Console.WriteLine("4. Show Top 3 Students");
//            Console.WriteLine("5. Exit");
//            Console.Write("Enter your choice: ");
//            return int.Parse(Console.ReadLine());
//        }

//        // Add Student
//        static void AddStudent()
//        {
//            Console.Write("Enter Student Name: ");
//            string name = Console.ReadLine();
//            Console.Write("Enter Matric Marks (Out of 1100): ");
//            double matricMarks = double.Parse(Console.ReadLine());
//            Console.Write("Enter Fsc Marks (Out of 1100): ");
//            double fscMarks = double.Parse(Console.ReadLine());
//            Console.Write("Enter ECAT Marks (Out of 400): ");
//            double ecatMarks = double.Parse(Console.ReadLine());

//            Student newStudent = new Student(name, matricMarks, fscMarks, ecatMarks);
//            students.Add(newStudent);

//            Console.WriteLine("Student Added Successfully!");
//        }

//        // Show All Students
//        static void ShowStudents()
//        {
//            if (students.Count == 0)
//            {
//                Console.WriteLine("No students found!");
//                return;
//            }

//            Console.WriteLine("List of Students:");
//            foreach (Student student in students)
//            {
//                student.ShowStudent();
//            }
//        }

//        // Calculate Aggregates for All Students
//        static void CalculateAggregates()
//        {
//            if (students.Count == 0)
//            {
//                Console.WriteLine("No students found!");
//                return;
//            }

//            Console.WriteLine("Aggregates of Students:");
//            foreach (Student student in students)
//            {
//                student.CalculateAggregate();
//                Console.WriteLine($"{student.Name}: {student.Aggregate:F2}%");
//            }
//        }

//        // Show Top 3 Students
//        static void ShowTopStudents()
//        {
//            if (students.Count == 0)
//            {
//                Console.WriteLine("No students found!");
//                return;
//            }

//            var topStudents = new List<Student>(students);
//            topStudents.Sort((s1, s2) => s2.Aggregate.CompareTo(s1.Aggregate)); // Sort in descending order

//            Console.WriteLine("Top 3 Students:");
//            for (int i = 0; i < Math.Min(3, topStudents.Count); i++)
//            {
//                topStudents[i].ShowStudent();
//            }
//        }
//    }
//}
