// This is the online ordering program 

using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 information
        Address address1 = new Address("145 Faith Street", "Jacksonville", "Florida", 25643, "USA");
        Customer customer1 = new Customer("Jameson Booth", address1);

        // Customer 2 information
        Address address2 = new Address("635 James Circle", "Birmingham", "Alabama", 35646, "USA");
        Customer customer2 = new Customer("Amelia Jones", address2);

        // Customer 3 information
        Address address3 = new Address("842 Rue Iloko", "Lome", "Maritime", 00001, "Togo");
        Customer customer3 = new Customer("Jonas Mando", address3);

        // Products bought by each customer
        Product product1 = new Product("Necklace", "N526", 89.99M, 12);
        Product product2 = new Product("Dell Latitude 7686", "D14", 1059.99M, 2);
        Product product3 = new Product("LG 55 inch 8K Flat Screen TV", "L864", 5988.99M, 1);

        // Orders of each customer
        Order order1 = new Order(new List<Product> {product1, product3}, customer1);
        Order order2 = new Order(new List<Product> {product1, product2, product3}, customer2);
        Order order3 = new Order(new List<Product> {product2, product3}, customer3);

        // Adding each order into a list of orders
        List<Order> orders = new List<Order> {order1, order2, order3};

        int customerNumber = 1;

        Console.WriteLine();
        foreach (Order order in orders)
        {
            Console.WriteLine($" -----Customer {customerNumber}----- ");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total cost is {order.CalculateTotalCost():C}\n");
            customerNumber++;
        }


    }
}