public abstract class Vehicle : IRentable
{
    protected string vehicleNumber;
    protected double rentPerDay;
    protected Vehicle(string vehicleNumber, double rentPerDay)
    {
        this.vehicleNumber = vehicleNumber;
        this.rentPerDay = rentPerDay;
    }
    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }
    public abstract double CalculateRent(int days);

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle No: {vehicleNumber}");
    }
}
