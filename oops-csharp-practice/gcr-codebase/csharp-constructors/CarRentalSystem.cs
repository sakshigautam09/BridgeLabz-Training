using System;
class Car
{
    public string customerName;
    public string carModel;
    public int rentalDays;
    public double costPerDay = 1000;

    // Default Constructor
    public Car()
    {
        customerName = "John";
        carModel = "Nano";
        rentalDays = 1;
    }

    // Parameterized Constructor
    public Car(string name, string model, int days)
    {
        customerName = name;
        carModel = model;
        rentalDays = days;
    }

    public double CalculateTotalCost()
    {
        return rentalDays * costPerDay;
    }

    public void Display()
    {
        Console.WriteLine($"Customer: {customerName}");
        Console.WriteLine($"Car Model: {carModel}");
        Console.WriteLine($"Rental Days: {rentalDays}");
        Console.WriteLine($"Total Cost: ₹{CalculateTotalCost()}");
    }
}
class CarRentalSystem
{
    static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car("sakshi", "Sierra", 5);

        c1.Display();
        Console.WriteLine();
        c2.Display();
    }
}
