using System;

// Node
class ItemNode
{
    public int Id;
    public string Name;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price)
    {
        Id = id;
        Name = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

// Singly Linked List
class Inventory
{
    private ItemNode head;

    // Add at end (simple & common)
    public void AddItem(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    // Remove item by ID
    public void RemoveItem(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory empty.");
            return;
        }

        if (head.Id == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed.");
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.Id != id)
            temp = temp.Next;

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Item removed.");
    }

    // Update quantity by ID
    public void UpdateQuantity(int id, int newQty)
    {
        ItemNode temp = head;

        while (temp != null)
        {
            if (temp.Id == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found.");
    }

    // Search by ID
    public void SearchById(int id)
    {
        ItemNode temp = head;

        while (temp != null)
        {
            if (temp.Id == id)
            {
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item not found.");
    }

    // Search by Name
    public void SearchByName(string name)
    {
        ItemNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Item not found.");
    }

    // Total inventory value
    public void TotalValue()
    {
        double total = 0;
        ItemNode temp = head;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine($"Total Inventory Value = {total}");
    }

    // Sort by Name (ascending)
    public void SortByName()
    {
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (string.Compare(i.Name, j.Name) > 0)
                {
                    Swap(i, j);
                }
            }
        }
        Console.WriteLine("Sorted by Name.");
    }

    // Sort by Price (ascending)
    public void SortByPrice()
    {
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (i.Price > j.Price)
                {
                    Swap(i, j);
                }
            }
        }
        Console.WriteLine("Sorted by Price.");
    }

    // Swap data (easy way)
    private void Swap(ItemNode a, ItemNode b)
    {
        (a.Id, b.Id) = (b.Id, a.Id);
        (a.Name, b.Name) = (b.Name, a.Name);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }

    // Display all items
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory empty.");
            return;
        }

        Console.WriteLine("\n--- Inventory ---");
        ItemNode temp = head;
        while (temp != null)
        {
            DisplayItem(temp);
            temp = temp.Next;
        }
    }

    private void DisplayItem(ItemNode item)
    {
        Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Qty: {item.Quantity}, Price: {item.Price}");
    }
}

// Main
class InventoryManagementSystem
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddItem(101, "Pen", 50, 10);
        inventory.AddItem(102, "Notebook", 30, 50);
        inventory.AddItem(103, "Marker", 20, 25);

        inventory.DisplayAll();

        inventory.UpdateQuantity(102, 40);
        inventory.SearchByName("Pen");

        inventory.TotalValue();

        inventory.SortByName();
        inventory.DisplayAll();

        inventory.SortByPrice();
        inventory.DisplayAll();

        inventory.RemoveItem(101);
        inventory.DisplayAll();
    }
}
