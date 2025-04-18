using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    internal class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string program, int year, double fee , string name , string address): base (name,address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public Student()
        {

        }
        public void setprogram(string program)
        {
            this.program = program;
        }
        public string getprogram()
        {
            return program;
        }
        public void setyear(int year)
        {
            this.year = year;
        }
        public int getyear()
        {
            return year;
        }
        public void setfee(double fee)
        {
            this.fee = fee;
        }
        public double getfee()
        {
            return fee;
        }
    }
}
