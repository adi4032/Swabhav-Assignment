using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LineItem_order_.Model
{
    internal class Product
    {
        private int ProductId;
        private string ProductName;
        private double ProductPrice;
        private double DiscountPercent;

        public Product(int productId, string productName, double productPrice, double discountPercent)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountPercent = discountPercent;
        }
 
        public int getproductId() { return ProductId; }
        public string getProductName() { return ProductName; }
        public double getPrice() { return ProductPrice; }
        public double getDiscountPercent() { return DiscountPercent; }

        public double CalculateDiscountPrice()
        {
            double discountAmount = ProductPrice * (DiscountPercent / 100);
            return ProductPrice - discountAmount;
        }

    }
}