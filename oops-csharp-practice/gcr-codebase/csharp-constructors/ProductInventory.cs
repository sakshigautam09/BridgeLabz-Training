using System;
class Product
{
    // Instance variables (unique for each object)
    public string productName;
    public double price;

    // Class variable (shared among all objects)
    public static int totalProducts = 0;

    // Constructor
    public Product(string name, double p)
    {
        productName = name;
        price = p;
        totalProducts++;   // increases for every product created
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: ₹" + price);
    }

    // Class (static) method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}
class ProductInventory
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 55000);
        Product p2 = new Product("Mobile", 25000);
        Product p3 = new Product("Headphones", 3000);

        Console.WriteLine("---- Product Details ----");
        p1.DisplayProductDetails();
        Console.WriteLine();

        p2.DisplayProductDetails();
        Console.WriteLine();

        p3.DisplayProductDetails();
        Console.WriteLine();

        // Calling class method
        Product.DisplayTotalProducts();
    }
}
