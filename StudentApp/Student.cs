using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentApp
{
    internal class Student
    {
        private int RollNo;
        private string Name;
        private float Cgpa;
        
        public Student(int RollNo, string Name, float Cgpa)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Cgpa = Cgpa;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CGPA: {Cgpa}");
        }
        public void SetStudentCgpa(float Cgpa)
        {
            if (1 <= Cgpa && Cgpa <= 10)
            {
                this.Cgpa = Cgpa;
            }
            else
            {
                Console.WriteLine("Enter Valid Cgpa");
            }
        }
        public void SetStudentRollNumber(int RollNo)
        {
            if (RollNo > 0)
            {
                this.RollNo = RollNo;
            }
            else
            {
                Console.WriteLine("Roll Number can't be Negative");
            }
        }

        public void SetStudentName(string Name)
        {
           Name = (Name.Length < 5) ? "" : Name;
        }
        public double GetPercentage()
        {
            return Cgpa * 10; // Assuming CGPA is out of 10
        }

    }
}
