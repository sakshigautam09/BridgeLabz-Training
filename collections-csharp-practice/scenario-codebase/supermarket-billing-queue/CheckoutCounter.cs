using System;
using System.Collections.Generic;

public class CheckoutCounter
{
    private Queue<Customer> customerQueue = new Queue<Customer>();
    private Dictionary<string, (double Price, int Stock)> inventory = new Dictionary<string, (double, int)>();

    public void AddItemToInventory(string name, double price, int stock)
    {
        inventory[name] = (price, stock);
    }

    public void AddCustomer(Customer customer)
    {
        customerQueue.Enqueue(customer);
    }

    public void ProcessNextCustomer()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }

        Customer customer = customerQueue.Dequeue();
        double total = 0;

        Console.WriteLine("\nProcessing customer: " + customer.Name);

        foreach (var item in customer.ItemsToBuy)
        {
            if (inventory.TryGetValue(item, out var data))
            {
                if (data.Stock > 0)
                {
                    total += data.Price;
                    inventory[item] = (data.Price, data.Stock - 1);
                    Console.WriteLine("Item: " + item + ", Price: " + data.Price + ", Remaining Stock: " + (data.Stock - 1));
                }
                else
                {
                    Console.WriteLine("Item " + item + " is out of stock.");
                }
            }
            else
            {
                Console.WriteLine("Item " + item + " not found.");
            }
        }

        Console.WriteLine("Total bill for " + customer.Name + ": " + total + "\n");
    }

    public void DisplayQueue()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Customers in queue:");
        foreach (var c in customerQueue)
        {
            Console.WriteLine("- " + c.Name);
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("\nCurrent Inventory:");
        foreach (var kvp in inventory)
        {
            Console.WriteLine("Item: " + kvp.Key + ", Price: " + kvp.Value.Price + ", Stock: " + kvp.Value.Stock);
        }
    }
}
