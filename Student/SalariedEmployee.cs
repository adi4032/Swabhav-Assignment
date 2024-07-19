using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal abstract class SalariedEmployee : Person
    {
        public decimal Salary { get; set; }

        protected SalariedEmployee(int id, string address, DateTime dob, decimal salary)
            : base(id, address, dob)
        {
            Salary = salary;
        }

        public abstract decimal CalculateSalary();
    }
}
