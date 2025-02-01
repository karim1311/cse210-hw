using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("Miguel Hidalgo","Culiacán","Sinaloa","Mexico");

        Customer customer1 = new Customer("Karim Valenzuela",address1);

        Order order1 = new Order(customer1);

        order1.AddProduct("iPhone 14",1,500,1);
        order1.AddProduct("Trufru Strawberries and Milk Chocolate",2,10,2);
        order1.AddProduct("Soap Table",3,1.39,3);

        // order1.ShowProducts();

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.TotalCost());


        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        
        Address address2 = new Address("Heber Ave","Park City","Utah","United States");

        Customer customer2 = new Customer("William Doe",address2);

        Order order2 = new Order(customer2);

        order2.AddProduct("LG UltraGear Monitor",4,250,1);
        order2.AddProduct("Blue Men's Blazer",5,30,1);
        order2.AddProduct("Lindtt Dark Chocolate Salted Caramel",6,4,3);


        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.TotalCost());
        

        // order2.ShowProducts();
    }
}