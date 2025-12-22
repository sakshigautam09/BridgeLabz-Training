using System;
class CountDownUsingFor
{
    static void Main()
    {
        int counter;
        Console.Write("Enter countdown value: ");
        counter = Convert.ToInt32(Console.ReadLine());

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
