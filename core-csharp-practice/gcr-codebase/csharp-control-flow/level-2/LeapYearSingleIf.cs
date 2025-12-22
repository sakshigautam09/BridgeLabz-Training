using System;
class LeapYearSingleIf
{
    static void Main()
    {
        int year;
        Console.Write("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}
