using System;

public class CalculateSimpleInterest
{
    public static void Main(string[] args)
    {
        // Read principal, rate, and time from user
        double principal = double.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());

        // Calculate simple interest
        double interest = (principal * rate * time) / 100;

        // Print result
        Console.WriteLine("Simple Interest = " + interest);
    }
}