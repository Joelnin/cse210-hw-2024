using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        // For Order 1

        // Product 11 = Product 1 - Order 1 = Attribute11. And so on.
        string productName11 = "Oreos Vanilla";
        string productID11 = "Oreos-2001";
        float price11 = 3;
        int quantity11 = 9;

        Product product11 = new Product(productName11, productID11, price11, quantity11);

        // Product 12 = Product 2 - Order 1 = Attribute12. And so on.
        string productName12 = "Oreos Chocolate";
        string productID12 = "Oreos-2008-1";
        float price12 = 4;
        int quantity12 = 4;

        Product product12 = new Product(productName12, productID12, price12, quantity12);

        // Product 13 = Product 3 - Order 1 = Attribute13. And so on.
        string productName13 = "Oreos Lemon Pie";
        string productID13 = "Oreos-2038-15";
        float price13 = 7;
        int quantity13 = 9;

        Product product13 = new Product(productName13, productID13, price13, quantity13);

        List<Product> products11 = new List<Product>() {
            product11,
            product12,
            product13
        };

        // Customer 11
        string customerName11 = "Yasin Ordaz"; 

        // Address 11
        string street11 = "123 Main Street";
        string city11 = "Austin";
        string state11 = "Texas";
        string country11 = "United States";

        Address address11 = new Address(street11, city11, state11, country11);

        Customer customer11 = new Customer(customerName11, address11);

        Order order1 = new Order(products11, customer11);

        // For Order 2

        // Product 21 = Product 1 - Order 2 = Attribute21. And so on.
        string productName21 = "Pajamas";
        string productID21 = "Sleep-Wear-200015-Red";
        float price21 = 15;
        int quantity21 = 3;

        Product product21 = new Product(productName21, productID21, price21, quantity21);

        // Product 22 = Product 2 - Order 2 = Attribute22. And so on.
        string productName22 = "Dress";
        string productID22 = "Night-Gown-00002-LightGray";
        float price22 = 205;
        int quantity22 = 4;

        Product product22 = new Product(productName22, productID22, price22, quantity22);

        List<Product> products22 = new List<Product>() {
            product21,
            product22,
        };

        // Customer 21
        string customerName22 = "Ninsefora Manosalva"; 

        // Address 22
        string street22 = "Mariño Street";
        string city22 = "Cumana";
        string state22 = "Sucre";
        string country22 = "Venezuela";

        Address address22 = new Address(street22, city22, state22, country22);

        Customer customer22 = new Customer(customerName22, address22);

        Order order2 = new Order(products22, customer22);

        List<Order> orders = new List<Order>() {
            order1,
            order2
        };

        int i = 0;

        foreach (Order order in orders)
        {
            i++;

            Console.WriteLine($"Order N° {i}");

            order.DisplayPackingLabel();
            order.DisplayShippingLabel();
            
            Console.WriteLine($"Total cost: {order.CalculateTotalCost():N2} $");

            Console.WriteLine();
        }
    }
}