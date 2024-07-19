using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student(101, "rabale", new DateTime(2002, 1, 15), "Computer Science");
            Console.WriteLine(student.ToString());

            Professor professor = new Professor(102, "airoli", new DateTime(1990, 5, 12), 50000, "Engineering");
            Console.WriteLine(professor.ToString());
        }
    }
}
