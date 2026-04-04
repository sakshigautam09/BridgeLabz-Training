using System;
class LargestOfThree
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

        Console.WriteLine($"Is the first number the largest? {(n1 > n2 && n1 > n3 ? "Yes" : "No")}");
        Console.WriteLine($"Is the second number the largest? {(n2 > n1 && n2 > n3 ? "Yes" : "No")}");
        Console.WriteLine($"Is the third number the largest? {(n3 > n1 && n3 > n2 ? "Yes" : "No")}");
    }
}
