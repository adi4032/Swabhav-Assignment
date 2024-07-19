using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student : Person
    {
        public string Branch { get; set; }

        public Student(int id, string address, DateTime dob, string branch)
            : base(id, address, dob)
        {
            Branch = branch;
        }

        public override string ToString()
        {
            return $"Student ID: {Id}, Address: {Address}, DOB: {DateOfBirth.ToShortDateString()}, Branch: {Branch}";
        }
    }
}
