using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cadence = 0;
            int gear = 0;
            int speed = 0;
            Mountainbike mountain = new Mountainbike(cadence , gear ,speed);
            Console.WriteLine("Enter your cadence");
            mountain.cadence = int.Parse(Console.ReadLine());
            mountain.gear = int.Parse(Console.ReadLine());
            mountain.speed = int.Parse(Console.ReadLine());
            Console.WriteLine($"{mountain.cadence}  {mountain.gear} {mountain.speed}");            
        }
    }
}
