using System;
class CafeteriaMenuApp
{
    static string[] menuItems = new string[10]
    {
        "Veg Sandwich",
        "Cheese Burger",
        "French Fries",
        "Pasta",
        "Pizza",
        "Coffee",
        "Tea",
        "Cold Drink",
        "Ice Cream",
        "Chocolate Cake"
    };

    static double[] prices = new double[10] {40, 60, 50, 120, 150, 30, 20, 40, 70, 90};
    static double totalBill = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== CAFETERIA MENU =====");
            Console.WriteLine("1. Display Menu");
            Console.WriteLine("2. Order Item");
            Console.WriteLine("3. Calculate Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int chooseOption = int.Parse(Console.ReadLine());

            if (chooseOption == 1)
            {
                DisplayMenu();
            }
            else if (chooseOption == 2)
            {
                DisplayMenu();

                Console.Write("Enter item index: ");
                int index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= menuItems.Length)
                {
                    Console.WriteLine("Invalid item index");
                    continue;
                }

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                double amount = prices[index] * quantity;
                totalBill += amount;

                Console.WriteLine($"Added {menuItems[index]} x {quantity}");
                Console.WriteLine($"Item Cost: ₹{amount}");
            }
            else if (chooseOption == 3)
            {
                CalculateBill();
            }
            else if (chooseOption == 4)
            {
                Console.WriteLine("Thank you for visiting the Cafeteria!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

    // Method to display menu
    static void DisplayMenu()
    {
        Console.WriteLine("\n--- Menu Items ---");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i}. {menuItems[i]} - ₹{prices[i]}");
        }
    }

    // Method to calculate and display bill
    static void CalculateBill()
    {
        Console.WriteLine("\n===== BILL SUMMARY =====");
        Console.WriteLine("Total Bill Amount: ₹" + totalBill);
    }
}
