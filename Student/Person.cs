using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(int id, string address, DateTime dob)
        {
            Id = id;
            Address = address;
            DateOfBirth = dob;
        }
    }
}
