using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "Rexburg",
            "Idaho",
            "USA");

        Customer customer1 = new Customer(
            "Mary Olubunmi",
            address1);

        Product product1 = new Product(
            "Shoes",
            "S001",
            50.00,
            2);

        Product product2 = new Product(
            "Handbag",
            "B002",
            35.00,
            1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Order 2 - Customer outside the USA
        Address address2 = new Address(
            "15 Allen Avenue",
            "Ikeja",
            "Lagos",
            "Nigeria");

        Customer customer2 = new Customer(
            "Bella Olubunmi",
            address2);

        Product product3 = new Product(
            "Dress",
            "D003",
            45.00,
            2);

        Product product4 = new Product(
            "Necklace",
            "N004",
            20.00,
            1);

        Product product5 = new Product(
            "Sandals",
            "S005",
            30.00,
            1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");

        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}