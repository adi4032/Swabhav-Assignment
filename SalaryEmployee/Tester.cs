using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmployee
{
    internal class Tester:Employee,IEmployee
    {
        private const decimal OT = 0.30m;
        public Tester(int Id, string Name, decimal basic)
                : base(Id, Name, basic) { }

        public decimal CalculateCTC()
        {
            decimal Ot = OT * basic;
            return basic + Ot;
        }
    }
}
