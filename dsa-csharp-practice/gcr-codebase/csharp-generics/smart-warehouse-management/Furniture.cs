using System;

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, string material, int quantity)
        : base(name, quantity)
    {
        Material = material;
    }

    public override void Display()
    {
        Console.WriteLine($"Furniture | Name: {Name}, Material: {Material}, Quantity: {Quantity}");
    }
}
