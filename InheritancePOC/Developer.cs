using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePOC
{
    internal class Developer:Employee
    {
        public void Code()
        {
            Console.WriteLine($"{this.Name} is coding.");
        }
    }
}
