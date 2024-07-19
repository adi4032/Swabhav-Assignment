using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePOC
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Work()
        {
            Console.WriteLine($"{this.Name} is working.");
        }

        public void TakeBreak()
        {
            Console.WriteLine($"{this.Name} is taking a break.");
        }
    }
}
