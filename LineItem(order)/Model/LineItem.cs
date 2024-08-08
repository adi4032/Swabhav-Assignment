using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineItem_order_.Model
{
    internal class LineItem
    {
        private int _Id { get; set; }
        private int Quantity { get; set; }
        private Product _product;

        public LineItem(int id, int quantity, Product product)
        {
            _Id = id;
            Quantity = quantity;
            _product = product;
        }

        public int getId() { return _Id; }
        public int getQuantity() { return Quantity; }
        public Product getProduct() { return _product; }

        public double CalculateLineItemCost()
        {
            double finalPrice = _product.CalculateDiscountPrice();
            return finalPrice * Quantity;
        }
    }
}
