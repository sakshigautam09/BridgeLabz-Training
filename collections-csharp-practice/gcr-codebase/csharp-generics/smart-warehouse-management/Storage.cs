using System;
using System.Collections.Generic;

public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} added to storage");
    }

    public void DisplayAllItems()
    {
        Console.WriteLine("\n--- Storage Items ---");
        foreach (T item in items)
        {
            item.Display();
        }
    }
}
