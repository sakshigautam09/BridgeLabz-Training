using System;
class EuclideanDistance
{
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double dx = Math.Pow(x2 - x1, 2);
        double dy = Math.Pow(y2 - y1, 2);
        return Math.Sqrt(dx + dy);
    }
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];
        if (x2 == x1)
        {
            result[0] = double.NaN;
            result[1] = double.NaN;
            return result;
        }
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - (m * x1);
        result[0] = m;
        result[1] = b;

        return result;
    }

    static void Main()
    {
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = FindDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance = " + distance);

        double[] line = FindLineEquation(x1, y1, x2, y2);

        if (!double.IsNaN(line[0]))
        {
            Console.WriteLine("Slope= " + line[0]);
            Console.WriteLine("Y-Intercept= " + line[1]);
            Console.WriteLine($"Equation of line: y = {line[0]}x + {line[1]}");
        }
    }
}
