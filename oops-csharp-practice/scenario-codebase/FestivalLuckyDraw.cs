using System;
class LuckyDraw
{
    // Public data member
    public int number;

    // Constructor
    public LuckyDraw(int num)
    {
        number = num;
    }
    public void CheckLuckyNumber()
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Congratulations! You won a gift!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}

class FestivalLuckyDraw
{
    static void Main()
    {
        string chooseOption;

        Console.WriteLine("Welcome to Diwali Festival Lucky Draw!");

        while (true)
        {
            Console.Write("\nEnter your lucky number: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int num);

            if (!isValid || num <= 0)
            {
                Console.WriteLine("Invalid input! Try again.");
                continue;
            }
            // object
            LuckyDraw visitor = new LuckyDraw(num);

            visitor.CheckLuckyNumber();

            Console.Write("Next visitor? (yes/no): ");
            chooseOption = Console.ReadLine().ToLower();

            if (chooseOption == "no")
            {
                Console.WriteLine("\nLucky Draw Ended. Happy Diwali!");
                break;
            }
        }
    }
}
