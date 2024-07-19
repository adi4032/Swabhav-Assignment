using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager myManager = new Manager();
            myManager.Name = "Ram";
            myManager.Age = 25;

            myManager.Work();
            myManager.TakeBreak();
            myManager.Manage();

            Console.WriteLine(); 
            Developer myDeveloper = new Developer();
            myDeveloper.Name = "Sham";
            myDeveloper.Age = 30;

            myDeveloper.Work();
            myDeveloper.TakeBreak();

            myDeveloper.Code();
        }
    }
}