using System;

class Program
{
    static void Main()
    {
        CheckoutCounter counter = new CheckoutCounter();

        // Input inventory from user
        Console.Write("Enter number of items in inventory: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Item name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            counter.AddItemToInventory(name, price, stock);
        }

        counter.DisplayInventory();

        // Input customers
        Console.Write("Enter number of customers: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            Console.Write("Customer name: ");
            string customerName = Console.ReadLine();
            Customer customer = new Customer(customerName);

            Console.Write("How many items for " + customerName + "? ");
            int itemCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < itemCount; j++)
            {
                Console.Write("Enter item name: ");
                string itemName = Console.ReadLine();
                customer.AddItem(itemName);
            }

            counter.AddCustomer(customer);
        }

        counter.DisplayQueue();

        // Process all customers
        while (true)
        {
            Console.WriteLine("\nProcess next customer? (yes/no)");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes") break;

            counter.ProcessNextCustomer();
        }

        Console.WriteLine("All customers processed.");
    }
}
