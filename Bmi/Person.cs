using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bmi
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double height { get; set; }
        public int weight { get; set; }

        public Person(int id, string name, int age)
        : this(id, name, age, 5, 150)
        {
        }
        public Person(int id, string name, int age, double height, int weight)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public double CalculateBmi()
        {
            double heightInMeters = height * 0.3048;
            double bmi = weight / (heightInMeters * heightInMeters);
            return bmi;
        }

        public string PrintDetails()
        {
            return $"ID: {id}, Name: {name}, Age: {age}, Height: {height}ft, Weight: {weight}kg";
        }

        public string GetBodyType()
        {
            double bmi = CalculateBmi();

            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                return "Normal";
            }
            else
            {
                return "Overweight";
            }

        }

    }
}
