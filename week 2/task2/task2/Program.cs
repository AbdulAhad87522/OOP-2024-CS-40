using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 ,number2 ;
            Calculator calculator;
            int option = menu();
            while(option != 5)
            {
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        calculator = new Calculator(number1, number2);
                       Console.WriteLine( calculator.addition(number1,number2));
                        break;
                    case 2:
                        Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        calculator = new Calculator(number1, number2);
                        calculator.subtraction(number1, number2);
                        break;
                    case 3:
                        Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        calculator = new Calculator(number1, number2);
                        calculator.multiplicatoion(number1, number2);
                        break;
                    case 4:
                        Console.WriteLine("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        calculator = new Calculator(number1, number2);
                        calculator.division(number1, number2);
                        break;
                }
                option = menu();
            }
        }
        class Calculator
        {
            public Calculator(int number1,int number2)
            {
                Number1 = number1;
                Number2 = number2;
            }
            public int Number1;
            public int Number2;
            public int addition(int number1,int number2)
            {
                int result = number1 +number2;
                return result;
            }
            public int subtraction(int number1, int number2)
            {
                int result = number1 - number2;
                return result;
            }
            public int multiplicatoion(int number1,int number2)
            {
                int result = number1 * number2;
                return result;
            }
            public int division(int number1, int number2)
            {
                int result = number1 / number2;
                return result;
            }
        }
        public static int menu()
        {
            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("Enter your option: ");
            int result = int.Parse(Console.ReadLine());
            return result;
        }

    }
}
