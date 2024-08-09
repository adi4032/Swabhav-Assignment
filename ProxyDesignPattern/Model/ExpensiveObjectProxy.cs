using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    internal class ExpensiveObjectProxy:IExpensiveObject
    {
        private ExpensiveObject expensiveObject;

        public void Process()
        {
            if (expensiveObject == null)
            {
                expensiveObject = new ExpensiveObject();
            }

            expensiveObject.Process();
        }
    }
}
