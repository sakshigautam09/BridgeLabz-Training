using System;

public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    protected Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    public abstract double CalculateRentalCost(int days);

    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Rate: " + rentalRate);
    }
}
