using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practise
{
    internal class Student
    {
        public String name;
        public String major;
        public double gpa;

        public Student(string aName, String aMajor, double aGpa) 
        { 
            name = aName;   
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors() // Student class's method.
        {
            if (gpa >= 2.5)
            {
                return true;
            }
            return false;
        }
    }
}
