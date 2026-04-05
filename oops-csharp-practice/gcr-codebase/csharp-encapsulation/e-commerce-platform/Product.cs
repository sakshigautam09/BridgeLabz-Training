using System;

public abstract class Product
{
    private int productId;
    private string name;
    private double price;

    protected Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public abstract double CalculateDiscount();

    public void DisplayDetails()
    {
        Console.WriteLine("Product ID: " + productId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}
