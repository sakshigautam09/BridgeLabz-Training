using System;
class TrigonometricFunctions
{
    public static double[] calculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;
        return new double[] { Math.Sin(radians), Math.Cos(radians), Math.Tan(radians) };
    }
    static void Main()
    {
        double angle = double.Parse(Console.ReadLine());
        double[] ans = calculateTrigonometricFunctions(angle);
        Console.WriteLine("Sin: " + ans[0]);
        Console.WriteLine("Cos: " + ans[1]);
        Console.WriteLine("Tan: " + ans[2]);
    }
}
