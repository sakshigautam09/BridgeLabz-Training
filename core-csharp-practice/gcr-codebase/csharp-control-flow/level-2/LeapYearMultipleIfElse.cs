using System;

class LeapYearMultipleIfElse
{
    static void Main()
    {
        int year;
        Console.Write("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Year must be >= 1582");
        }
        else if (year % 400 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine("Not a Leap Year");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }
}
