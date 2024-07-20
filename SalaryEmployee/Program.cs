using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEmployee[] employee = new IEmployee[]
            { new Developer(101, "Adi", 50000),new ProjectManager(102,"ram",40000),new Tester(103,"sham",45000) };

        }
    }
}
