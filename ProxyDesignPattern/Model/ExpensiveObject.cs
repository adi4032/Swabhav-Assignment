using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    internal class ExpensiveObject:IExpensiveObject
    {
        public ExpensiveObject()
        {
            Console.WriteLine("Initializing ExpensiveObject");
        }

        public void Process()
        {
            Console.WriteLine("Processing using ExpensiveObject");
        }
    }
}
