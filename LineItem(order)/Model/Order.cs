using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineItem_order_.Model
{
    internal class Order
    {
        private int _Id;
        private DateOnly Date;

        private List<LineItem> LineItems;

        public Order(int id, DateOnly date, List<LineItem> lineItems)
        {
            _Id = id;
            Date = date;
            LineItems = lineItems;

        }
        public int Id { get { return _Id; } }
        public DateOnly DateOnly { get { return Date; } }

        public List<LineItem> GetLineItems()
        {
            return LineItems;
        }
        public double CalculateOrderPrice()
        {
            double totalPrice = 0;
            foreach (var lineItem in LineItems)
            {
                totalPrice += lineItem.CalculateLineItemCost();
            }
            return totalPrice;
        }
    }
}
