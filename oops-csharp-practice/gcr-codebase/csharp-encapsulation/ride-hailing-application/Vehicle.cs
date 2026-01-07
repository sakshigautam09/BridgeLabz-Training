using System;
abstract class Vehicle : IGPS
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;
    private string location;

    protected Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
        this.location = "Not Assigned";
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {vehicleId}");
        Console.WriteLine($"Driver Name: {driverName}");
        Console.WriteLine($"Rate per KM: {ratePerKm}");
    }

    // IGPS implementation
    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }

    protected double RatePerKm
    {
        get { return ratePerKm; }
    }
}
