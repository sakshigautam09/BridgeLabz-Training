using System;

public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(string name, string brand, int quantity)
        : base(name, quantity)
    {
        Brand = brand;
    }

    public override void Display()
    {
        Console.WriteLine($"Electronics | Name: {Name}, Brand: {Brand}, Quantity: {Quantity}");
    }
}
