using System;

class DoubleOperation
{
    static void Main()
    {
        Console.Write("Enter a (double): ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b (double): ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c (double): ");
        double c = Convert.ToDouble(Console.ReadLine());

        double op1 = a + b * c;
        double op2 = a * b + c;
        double op3 = c + a / b;
        double op4 = a % b + c;

        Console.WriteLine($"The results of Double Operations are {op1}, {op2}, {op3}, {op4}");
    }
}
