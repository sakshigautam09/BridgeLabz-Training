using System;
class SumOfNumbersUntilZeroUsingBreak
{
    static void Main()
    {
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a num: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
                break;
            sum += n;
        }

        Console.WriteLine("Total sum = " + sum);
    }
}
