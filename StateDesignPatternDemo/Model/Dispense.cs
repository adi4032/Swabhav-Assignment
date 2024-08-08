using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Model
{
    internal class Dispense:IVendingMachine
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Please wait for the product to dispense.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Please wait for the current transaction to complete.");
        }

        public void Dispensing(VendingMachine machine)
        {
            Console.WriteLine("Dispensing product.");
            machine.State = new NoCoins();
        }
    }
}
