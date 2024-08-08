using LineItem_order_.Model;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(1, "charger", 1000, 10);
        //Product product2 = new Product(2, "Smartphone", 1000, 10);

        LineItem lineItem1 = new LineItem(1, 2, product1);
        //LineItem lineItem2 = new LineItem(2, 3, product2);

        //List<LineItem> lineItems1 = new List<LineItem> { lineItem1,lineItem2 };

        List<LineItem> lineItems1 = new List<LineItem> { lineItem1 };

        Order order1 = new Order(1, DateOnly.FromDateTime(DateTime.Now), lineItems1);

        Customer customer = new Customer(101, "ram", new List<Order> { order1 });

        Console.WriteLine($"Customer ID: {customer.Id}");
        Console.WriteLine($"Customer Name: {customer.Name}");
        Console.WriteLine($"Order Count: {customer.GetOrders().Count}");
        double totalLineItemCost = product1.CalculateDiscountPrice() * lineItem1.getQuantity();
        foreach (var order in customer.GetOrders())
        {
            Console.WriteLine($"Order ID: {order.Id}");
            Console.WriteLine($"Order Date: {order.DateOnly}");
        
            foreach(LineItem lineItem in lineItems1)
            {
              Console.WriteLine($"{"LineItemId"}|{"ProductId",-10}|{"ProductName",-15}|{"Quantity",-10}|{"UnitPrice",-10}|{"Discount%",-10}|{"UnitCostAfterDiscount",-10}");
              Console.WriteLine($"{lineItem.getId(),-10}|{product1.getproductId(),-10}|{product1.getProductName(),-15}|{lineItem.getQuantity(),-10} |{ product1.getPrice(),-10}|{product1.getDiscountPercent(),-10}|{product1.CalculateDiscountPrice(),-10}|{totalLineItemCost,-10}");
            }
        }

    }
}
