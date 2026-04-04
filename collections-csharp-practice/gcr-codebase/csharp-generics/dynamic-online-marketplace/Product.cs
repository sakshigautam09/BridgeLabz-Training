using System;

public class Product
{
    public string Name { get; }
    public double Price { get; private set; }
    public Category Category { get; }

    public Product(string name, double price, Category category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void ApplyDiscount(double percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void Display()
    {
        Console.WriteLine(
            $"Name: {Name}, Category: {Category.Name}, Price: {Price}"
        );
    }
}
