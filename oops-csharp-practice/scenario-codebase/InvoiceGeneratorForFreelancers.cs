using System;
class InvoiceGeneratorForFreelancers
{
    static void Main()
    {
        string input = "";
        string[] tasks = null;
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Invoice Generator Menu ===");
            Console.WriteLine("1. Enter Invoice Details");
            Console.WriteLine("2. Display Parsed Invoice");
            Console.WriteLine("3. Calculate Total Amount");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int chooseOption = int.Parse(Console.ReadLine());

            switch (chooseOption)
            {
                case 1:
                    Console.WriteLine("\nEnter invoice details:");
                    Console.WriteLine("Example Format: Logo Design - 3000 INR, Web Page - 4500 INR");
                    input = Console.ReadLine();
                    parsedInput = ParseInvoice(input);
                    Console.WriteLine("Invoice data saved successfully.");
                    break;

                case 2:
                    if (parsedInput == null)
                    {
                        Console.WriteLine("Please enter invoice details first.");
                    }
                    else
                    {
                        DisplayInvoice(parsedInput);
                    }
                    break;

                case 3:
                    if (parsedInput == null)
                    {
                        Console.WriteLine("Please enter invoice details first.");
                    }
                    else
                    {
                        int total = GetTotalAmount(parsedInput);
                        Console.WriteLine($"Total Invoice Amount: {total} INR");
                    }
                    break;

                case 4:
                    exit = true;
                    Console.WriteLine("Exiting Invoice Generator...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    public static string[] ParseInvoice(string input)
    {
        return input.Split(',');
    }
    private static void DisplayInvoice(string[] parsedInput)
    {
        Console.WriteLine("\n--- Invoice Details ---");
        foreach (string s in parsedInput)
        {
            Console.WriteLine(s.Trim());
        }
    }
    public static int GetTotalAmount(string[] tasks)
    {
        int total = 0;
        foreach (string task in tasks)
        {
            // Split "Logo Design - 3000 INR"
            string[] parts = task.Split('-');

            if (parts.Length == 2)
            {
                string amountPart = parts[1].Replace("INR", "").Trim();
                int amount = int.Parse(amountPart);
                total += amount;
            }
        }
        return total;
    }
}
