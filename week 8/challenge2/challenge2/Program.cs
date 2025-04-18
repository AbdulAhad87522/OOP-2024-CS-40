using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Program
    {
        public static List<Cylinder> cylinde = new List<Cylinder>();
        static void Main(string[] args)
        {
            int number = 0;
            while (number != 1)
            {
                Cylinder cylinder = new Cylinder();
                Console.WriteLine("Enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the color of the cylinder: ");
                string color = Console.ReadLine();
                cylinder.setcolor(color);
                cylinder.setheight(height);
                cylinder.setradius(radius);
                double volume = cylinder.getvolume();
                Console.WriteLine($"The volume will be: {volume}");
                Console.WriteLine($"And its color is: {color}");
                cylinde.Add(cylinder);
                Console.ReadKey();
                Console.WriteLine("Enter the color of the cylinder: ");
                string colour = Console.ReadLine();
                //string coolor = cylinder.getcolor();
                foreach (var d in cylinde)
                {

                    if (d.getcolor() == colour)
                    {
                        Console.WriteLine($"The volume of that specific cylinder is: {d.getvolume()}");
                    }

                }
                Console.WriteLine("Enter the choice: ");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
