using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Cars
    {
        private string model;
        private string color;
        private double price;
        public Cars()
        {

        }
        public Cars(string model, string color, double price)
        {
            this.model = model;
            this.color = color;
            this.price = price;
        }
        public void setmodel(string model)
        {
            this.model = model;
        }
        public string getmodel()
        {
            return this.model;
        }
        public void setcolor(string color)
        {
            this.color = color;
        }
        public string getcolor()
        {
            return this.color;
        }
        public void setprice(double price)
        {
            this.price = price;
        }
        public double getprice()
        {
            return this.price;
        }
    }
}
