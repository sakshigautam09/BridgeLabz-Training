using System;
class BasicCalculator
{
    static void Main()
    {
        int a = ReadNumber("Enter first number: ");
        int b = ReadNumber("Enter second number: ");

        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.Write("Choose operation: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Console.WriteLine("Result: " + Add(a, b)); break;
            case 2: Console.WriteLine("Result: " + Subtract(a, b)); break;
            case 3: Console.WriteLine("Result: " + Multiply(a, b)); break;
            case 4: Console.WriteLine("Result: " + Divide(a, b)); break;
            default: Console.WriteLine("Invalid choice"); break;
        }
    }
    static int ReadNumber(string msg)
    {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b) {
        return a - b;
    }
    static int Multiply(int a, int b) {
        return a * b;
    }
    static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}
