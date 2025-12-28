using System;
class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100:");
        Console.WriteLine("Press Enter when you're ready...");
        Console.ReadLine();

        int low = 1;
        int high = 100;
        int attempts = 0;
        Random rand = new Random();
        string feedback = "";

        while (feedback != "c")
        {
            int guess = rand.Next(low, high + 1);
            attempts++;
            Console.WriteLine($"Is your number {guess}? (h, l or c)");
            feedback = Console.ReadLine().ToLower();

            if (feedback == "h")
            {
                high = guess - 1;
            }
            else if (feedback == "l")
            {
                low = guess + 1;
            }
            else if (feedback != "c")
            {
                Console.WriteLine("Invalid input. Please enter 'h', 'l', or 'c'.");
            }
        }
        Console.WriteLine($"I guessed your number in {attempts} attempts.");
    }
}