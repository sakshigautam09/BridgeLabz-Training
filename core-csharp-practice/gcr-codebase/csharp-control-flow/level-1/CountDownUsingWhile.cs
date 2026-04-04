using System;
class CountDownUsingWhile
{
    static void Main()
    {
        int counter;
        Console.Write("Enter countdown value: ");
        counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
