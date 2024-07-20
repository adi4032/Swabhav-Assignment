using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmployee
{
    public class ProjectManager : Employee, IEmployee
    {
        private const decimal HRA = 0.50m;
        private const decimal DA = 0.40m;
        private const decimal TA = 0.50m;
        public ProjectManager(int Id, string Name, decimal basic)
                : base(Id, Name, basic) { }

        public  decimal CalculateCTC()
        {
            decimal Hra = HRA * basic;
            decimal Da = DA * basic;
            decimal Ta = TA * basic;
            return basic + Hra + Da + Ta;
        }
    }
}
