using System;
class CheckNumber
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("positive");
        else if (n < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("zero");
    }
}
