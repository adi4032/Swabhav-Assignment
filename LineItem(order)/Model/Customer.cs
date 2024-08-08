using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineItem_order_.Model
{
    internal class Customer
    {
        private int CustomerId;
        private string CustomerName;
        private List<Order> Orders;

        public Customer(int customerId, string customerName, List<Order> orders)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Orders = orders;
        }
        public int Id
        {
            get { return CustomerId; }
            set { CustomerId = value; }
        }

        public string Name
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }
    }
}
