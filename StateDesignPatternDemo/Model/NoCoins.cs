using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Model
{
    internal class NoCoins:IVendingMachine
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Coin inserted.");
            machine.State = new HasCoins();
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Please insert coin first.");
        }

        public void Dispensing(VendingMachine machine)
        {
            Console.WriteLine("No product selected.");
        }
    }
}
