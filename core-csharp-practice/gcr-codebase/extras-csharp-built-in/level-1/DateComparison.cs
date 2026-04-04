using System;
class DateComparison
{
    static void Main()
    {
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        if (date1 < date2)
        {
            Console.WriteLine("First date is BEFORE the second date");
        }
        else if (date1 > date2)
        {
            Console.WriteLine("First date is AFTER the second date");
        }
        else
        {
            Console.WriteLine("Both dates are the SAME");
        }
    }
}