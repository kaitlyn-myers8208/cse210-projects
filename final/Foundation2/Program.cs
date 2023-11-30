using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1164 Morning Glory Circle", "Westport", "CT", "USA");
        Customer customer1 = new Customer("Darrin Stephens", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Pretzels", 1110, 2.24, 1);
        Product product2 = new Product("Mixed Nuts", 1029, 8.98, 4);
        order1.AddToProducts(product1);
        order1.AddToProducts(product2);


        Address address2 = new Address("7 Savile Row", "Burlington Gardens", "London", "England");
        Customer customer2 = new Customer("Phileas Fogg", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Doritos", 2341, 4.93, 2);
        Product product4 = new Product("Cookies", 5435, 4.58, 6);
        order2.AddToProducts(product3);
        order2.AddToProducts(product4);

        Console.WriteLine($"Packing Label:\n{order1.DisplayPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.DisplayShippingLabel()}\n");
        Console.WriteLine($"Total Price: {order1.CaclculateTotalOrderCost()}\n");

        Console.WriteLine($"Packing Label:\n{order2.DisplayPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.DisplayShippingLabel()}\n");
        Console.WriteLine($"Total Price: {order2.CaclculateTotalOrderCost()}\n");
    }
}