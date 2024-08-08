using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternDemo.Model
{
    internal interface IVendingMachine
    {
        void InsertCoin(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
        void Dispensing(VendingMachine machine);
    }
}
