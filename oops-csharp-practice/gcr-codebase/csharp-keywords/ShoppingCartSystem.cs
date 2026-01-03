using System;
class Product
{
    // static variable 
    public static double Discount = 10.0;

    // readonly variable
    public readonly int ProductID;

    // instance variables
    public string ProductName;
    public double Price;
    public int Quantity;

    // Constructor using 'this'
    public Product(int productID, string productName, double price, int quantity)
    {
        this.ProductID = productID;        // readonly assigned once
        this.ProductName = productName;    // resolves ambiguity
        this.Price = price;
        this.Quantity = quantity;
    }
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: ₹" + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Total Price After Discount: ₹" + CalculateTotal());
    }

    // Helper method
    private double CalculateTotal()
    {
        double total = Price * Quantity;
        return total - (total * Discount / 100);
    }
}

// Main class
class ShoppingCartSystem
{
    static void Main()
    {
        Product p1 = new Product(1, "Laptop", 50000, 1);
        Product p2 = new Product(2, "Headphones", 2000, 2);

        Console.WriteLine();

        // Using 'is' operator
        if (p1 is Product)
        {
            Console.WriteLine("p1 is a Product object");
            p1.DisplayProductDetails();
        }

        Console.WriteLine();

        // Update discount using static method
        Product.UpdateDiscount(15);

        if (p2 is Product)
        {
            Console.WriteLine("p2 is a Product object");
            p2.DisplayProductDetails();
        }
    }
}
