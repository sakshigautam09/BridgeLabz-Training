using System;
class Circle
{
    public double radius;
    // Default Constructor
    public Circle()
    {
        radius = 5.0;
    }

    // Parameterized Constructor (chained)
    public Circle(double r) : this()
    {
        radius = r;
    }

    public void Display()
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + area);
    }
class CircleClass
    {
        static void Main()
        {
            Circle c1 = new Circle();      // Default constructor
            c1.Display();

            Console.WriteLine();

            Circle c2 = new Circle(5);     // Parameterized constructor
            c2.Display();
        }
    }
}
