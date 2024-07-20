using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEmployee
{
    abstract public class Employee
    {

        public int Id {  get; set; }    
        public string Name {  get; set; }
        protected decimal basic {  get; set; }
        public string GetEmployeeDetails()
        {
            return $"Employee ID: {Id}\n" +
                   $"Employee Name: {Name}\n" +
                   $"Basic Salary: {basic:C}\n";
        }

        public Employee(int Id, string Name, decimal basic)
        {
            this.Id = Id;
            this.Name = Name;
            this.basic = basic;
        }
        //public abstract decimal CalculateCTC();
    }
}
