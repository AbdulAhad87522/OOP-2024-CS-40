using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selfassessment_UAMS_.BL
{
    internal class student
    {
        public string name;
        public int age;
        public double FSCmarks;
        public double ECATmarks;
        public student(string name , int age , double fscmarks , double ecatmarks)
        {
            this.name = name;
            this.age = age;
            FSCmarks = fscmarks;
            ECATmarks = ecatmarks;
        }
    }
}
