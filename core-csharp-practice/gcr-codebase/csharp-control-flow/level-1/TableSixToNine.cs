using System;
class TableSixToNine
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(n + " * " + i + " = " + (n * i));
        }
    }
}
