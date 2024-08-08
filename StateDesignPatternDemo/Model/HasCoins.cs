using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Model
{
    internal class HasCoins:IVendingMachine
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("You can only insert one coin at a time.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product selected.");
            machine.State = new Dispense();
        }

        public void Dispensing(VendingMachine machine)
        {
            Console.WriteLine("No product selected.");
        }
    }
}
