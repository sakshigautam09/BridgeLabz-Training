using System;
class Circle    
{
    public double Radius;

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Circle Radius: " + Radius);
        Console.WriteLine("Circle Area: " + CalculateArea());
        Console.WriteLine("Circle Circumference: " + CalculateCircumference());
    }
}
class AreaOfCircle
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Radius = 5.0;

        circle.DisplayDetails();
    }
}