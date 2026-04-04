using System;
class SimpleInterest
{
    static double CalcSI(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
    public static void Main()
    {
        double principal = double.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());
        double si = CalcSI(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
