using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P1001", 999.99, 1),
            new Product("Mouse", "P1002", 25.50, 2)
        };

        Order order1 = new Order(customer1, products1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("-----------------------------------");

        // -------- Order 2 (International Customer) --------
        Address address2 = new Address(
            "456 Queen Street",
            "Toronto",
            "ON",
            "Canada"
        );

        Customer customer2 = new Customer("Emily Chen", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Tablet", "P2001", 450.00, 1),
            new Product("Headphones", "P2002", 80.00, 1),
            new Product("Charger", "P2003", 20.00, 2)
        };

        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    
    }
}