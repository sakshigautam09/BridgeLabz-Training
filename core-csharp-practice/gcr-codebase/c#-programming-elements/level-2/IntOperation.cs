using System;

class IntOperation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int op1 = a + b * c;
        int op2 = a * b + c;
        int op3 = c + a / b;
        int op4 = a % b + c;

        Console.WriteLine($"The results of Int Operations are {op1}, {op2}, {op3}, {op4}");
    }
}
