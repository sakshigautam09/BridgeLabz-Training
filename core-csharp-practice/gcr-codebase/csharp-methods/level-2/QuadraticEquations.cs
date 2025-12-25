using System;
class QuadraticEquations
{
    static double[] Findarr(double a, double b, double c)
    {
        double det = Math.Pow(b, 2) - 4 * a * c;
        if (det < 0) return new double[0];
        if (det == 0)
            return new double[] { -b / (2 * a) };
        return new double[] { (-b + Math.Sqrt(det)) / (2 * a), (-b - Math.Sqrt(det)) / (2 * a) };
    }
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double[] arr = Findarr(a, b, c);
        if (arr.Length == 0)
            Console.WriteLine("No real arr");
        else
            foreach (double r in arr) Console.WriteLine("Root: " + r);
    }
}
