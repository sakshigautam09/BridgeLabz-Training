using System;

public abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    protected WarehouseItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public abstract void Display();
}
