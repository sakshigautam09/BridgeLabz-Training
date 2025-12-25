using System;
class RunningInTriangularPark
{
    static double CalcRounds(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return 5000 / perimeter;
    }
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(CalcRounds(a, b, c));
    }
}
