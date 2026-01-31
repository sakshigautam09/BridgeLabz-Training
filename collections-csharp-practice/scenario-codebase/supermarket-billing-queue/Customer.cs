using System.Collections.Generic;

public class Customer
{
    public string Name { get; }
    public List<string> ItemsToBuy { get; }

    public Customer(string name)
    {
        Name = name;
        ItemsToBuy = new List<string>();
    }

    public void AddItem(string item)
    {
        ItemsToBuy.Add(item);
    }
}
