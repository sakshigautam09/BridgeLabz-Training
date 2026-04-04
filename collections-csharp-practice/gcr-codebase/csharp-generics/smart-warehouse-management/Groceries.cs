using System;

public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, DateTime expiryDate, int quantity)
        : base(name, quantity)
    {
        ExpiryDate = expiryDate;
    }

    public override void Display()
    {
        Console.WriteLine($"Groceries | Name: {Name}, Expiry: {ExpiryDate.ToShortDateString()}, Quantity: {Quantity}");
    }
}
