using System;
class NumberOfChocolates
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int perHead = numberOfChocolates / numberOfChildren;
        int remaining = numberOfChocolates % numberOfChildren;

        Console.WriteLine($"The number of chocolates each child gets is {perHead} and the number of remaining chocolates is {remaining}");
    }
}
