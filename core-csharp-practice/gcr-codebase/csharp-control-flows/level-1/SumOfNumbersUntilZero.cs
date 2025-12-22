using System;
class SumOfNumbersUntilZero
{
    static void Main()
    {
        int sum = 0;
        int n;

        Console.Write("Enter num: ");
        n = Convert.ToInt32(Console.ReadLine());

        while (n != 0)
        {
            sum += n;
            Console.Write("Enter a numb: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Total sum = " + sum);
    }
}
