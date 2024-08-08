using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Model
{
    internal class VendingMachine
    {
        private IVendingMachine state;

        public VendingMachine()
        {
            State = new NoCoins();
        }

        public IVendingMachine State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine($"Vending Machine: {state.GetType().Name}");
            }
        }

        public void InsertCoin()
        {
            state.InsertCoin(this);
        }

        public void SelectProduct()
        {
            state.SelectProduct(this);
        }

        public void Dispensing()
        {
            state.Dispensing(this);
        }
    }
}
