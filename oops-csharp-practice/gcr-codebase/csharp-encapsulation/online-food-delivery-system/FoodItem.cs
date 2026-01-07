using System;

public abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    protected FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + itemName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Quantity: " + quantity);
    }

    public abstract double CalculateTotalPrice();
}
