using System;
class SmallestOfThree
{
    static void Main()
    {
        int n1, n2, n3;
        Console.Write("Enter first number: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 < n2 && n1 < n3)
            Console.WriteLine("Is the first number the smallest? Yes");
        else
            Console.WriteLine("Is the first number the smallest? No");
    }
}
