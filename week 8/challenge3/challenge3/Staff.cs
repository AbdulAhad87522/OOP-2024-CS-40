﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    internal class Staff : Person
    {
        private string school;
        private double pay;
        public Staff(string name , string address , string  school, double pay) : base(name , address)
        {
            this.school = school;
            this.pay = pay;
        }
        public Staff()
        {

        }
        public string getschool()
        {
            return school;
        }
        public void setachool(string school)
        {
            this.school = school;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }
        public double getpay()
        {
            return pay;
        }
    }
}
