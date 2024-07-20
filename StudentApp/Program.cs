using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(101, "aditya", 8.5f);

            student.DisplayInfo();
            
            double percentage = student.GetPercentage();
            Console.WriteLine($"Percentage: {percentage}%");
            student.SetStudentCgpa(11.0f);
            student.SetStudentRollNumber(-1);
            student.SetStudentName("111");
            Console.ReadLine();
        }
    }
}
