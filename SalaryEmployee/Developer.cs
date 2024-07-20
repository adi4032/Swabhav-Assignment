using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmployee
{
    public class Developer:Employee,IEmployee
    {

        private const decimal PA = 0.40m;
        private const decimal TA = 0.30m;
        public Developer(int Id, string Name, decimal basic)
                : base(Id, Name, basic) { }

        public decimal CalculateCTC()
        {
            decimal Pa= PA * basic;
            decimal Ta = TA* basic;
            return basic+Pa+Ta;
        }
    }
}
