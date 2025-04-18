using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        { }
        public Cylinder(double radius , double height) : base(radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public Cylinder(double radius , double height , string color) : base(radius , color) 
        {
            this.height = height;
            this.color = color;
            this.height = height;
        }
        public double getheight()
        {
            return height;
        }
        public void setheight(double height)
        {
            this.height = height;
        }
        public double getvolume()
        {
            double volume = 0;
            volume = height * radius * height;
            return volume; 
        }
    }
}
