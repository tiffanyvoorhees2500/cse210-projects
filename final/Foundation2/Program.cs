using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = [];

        //Order Number 1
        //Step 1. Create a customer for the order (customer needs an address)
        Address address1 = new Address("1234 S Sunny St","Mesa","AZ","USA");
        Customer customer1 = new Customer("Tiffany Voorhees", address1);

        //Step 2. Create the products for the customer order
        List<Product> order1products = [];
        Product order1product1 = new Product("Digestion","1234",(Decimal)12.95,2);
        Product order1product2 = new Product("Flora","2345",(Decimal)14.95,3);
        Product order1product3 = new Product("Multi-vitamin","4532",(Decimal)12,4);

        order1products.Add(order1product1);
        order1products.Add(order1product2);
        order1products.Add(order1product3);

        //Create the order
        Order order1 = new Order(customer1,order1products);

        orders.Add(order1);

        //Order Number 2
        //Step 1. Create a customer for the order (customer needs an address)
        Address address2 = new Address("1234 N Rainy Rd","Spanish Fork","UT","Not in USA");
        Customer customer2 = new Customer("David Makebelieve", address2);

        //Step 2. Create the products for the customer order
        List<Product> order2products = [];
        Product order2product1 = new Product("Digestion","1234",(Decimal)12.95,2);
        Product order2product2 = new Product("Flora","2345",(Decimal)14.95,3);
        Product order2product3 = new Product("Multi-vitamin","4532",(Decimal)12,4);

        order2products.Add(order2product1);
        order2products.Add(order2product2);
        order2products.Add(order2product3);

        //Create the order
        Order order2 = new Order(customer2,order2products);

        orders.Add(order2);

        //Loop through each order and display:
        //    1. Packing Lablel
        //    2. Shipping Label
        //    3. Total Price of order
        foreach (Order order in orders)
        {
            Console.WriteLine($"Order for: {order.GetCustomerName()}");
            Console.WriteLine("");
            Console.WriteLine("Ship To: ");
            Console.WriteLine(order.GetShippingLabelStringRepresentation());
            Console.WriteLine("");
            Console.WriteLine("Packing List: ");
            Console.WriteLine(order.GetPackingLabelStringRepresentation());
            Console.WriteLine("");
            Console.WriteLine(order.GetTotalStringRepresentation());
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("");
        
        }
    }
}