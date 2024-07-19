using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePOC
{
    internal class Manager:Employee
    {
        public void Manage()
        {
            Console.WriteLine($"{this.Name} is managing the team.");
        }
    }
}
