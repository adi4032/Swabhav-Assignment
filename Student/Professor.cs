using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Professor:SalariedEmployee
    {
        public string Department { get; set; }

        public Professor(int id, string address, DateTime dob, decimal salary, string department)
            : base(id, address, dob, salary)
        {
            Department = department;
        }

        public override decimal CalculateSalary()
        {
            // Example logic for salary calculation
            // You can customize this logic as per requirements
            return Salary; // For simplicity, returning the base salary
        }

        public override string ToString()
        {
            return $"Professor ID: {Id}, Address: {Address}, DOB: {DateOfBirth.ToShortDateString()}, Department: {Department}, Salary: {CalculateSalary():C}";
        }
    }
}
