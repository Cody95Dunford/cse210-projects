using System;

class Program
{
    static void Main(string[] args)
    {
        /*create address*/
        Address address1 = new Address("211 Jim Henderson Road", "Falkville", "Alabama", "USA");
        /*create customer*/
        Customer customer1 = new Customer("Jim Henderson", address1);

        /*Product list*/
        List<Product> productList = new List<Product>();
        Product product1 = new Product("shampoo", 0001, 12.50, 1);
        Product product2 = new Product("conditioner", 0002, 12.50, 1);
        Product product3 = new Product("soap", 0003, 7.00, 10);

        /*add products to list*/
        productList.Add(product1);
        productList.Add(product2);
        productList.Add(product3);

        /*create order label*/
        Order order1 = new Order(productList, customer1);

        double total = order1.TotalPrice();
        string packing = order1.PackingLabel();
        string shipping = order1.ShippingList();

        Console.WriteLine($"The total cost is {total}");
        Console.WriteLine("\nPacking Label");
        Console.WriteLine(packing);
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(shipping);
    }
}