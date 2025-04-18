using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Circle
    {
        protected double radius;
        protected string color;
        public Circle()
        { }
        public Circle (double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius , string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getradius()
        {
            return radius;
        }
        public void setradius(double radius)
        {
            this.radius = radius;
        }
        public string getcolor()
        {
            return color;
        }
        public void setcolor(string color)
        {
            this.color = color;
        }
        public double getarea()
        {
            double area = 0;
            area = 2 * 3.14 * radius;
            return area;
        }
    }
}
