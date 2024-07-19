using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Person[] persons = new Person[4]
                {
                new Person(101, "Ram", 20, 5.5, 50),  
                new Person(102, "Aditya", 30, 6.0, 60),
                new Person(103, "Sham", 40, 5.0, 70),
                new Person(104, "Sachin", 50, 6.0, 80)
                };

           
                foreach (var person in persons)
                {
                    PrintDetails(person);
                }

                Person highestBmiPerson = GetPersonWithHighestBmi(persons);
                Console.WriteLine($"Person with highest BMI: {highestBmiPerson.name}");
            }

        }
        static void PrintDetails(Person person)
            {
                Console.WriteLine(person.PrintDetails());
                Console.WriteLine($"BMI is {person.CalculateBmi():F2}"); 
                Console.WriteLine($"Body Type: {person.GetBodyType()}");
                Console.WriteLine();
            }

            static Person GetPersonWithHighestBmi(Person[] persons)
            {
                Person highestBmiPerson = persons[0];

                foreach (Person p in persons)
                {
                    if (p.CalculateBmi() > highestBmiPerson.CalculateBmi())
                    {
                        highestBmiPerson = p;
                    }
                }

                return highestBmiPerson;
            }
        }
    }