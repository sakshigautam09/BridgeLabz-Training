public sealed class Bike : Vehicle
{
    public Bike(string vehicleNumber)
        : base(vehicleNumber, 300) { }

    public override double CalculateRent(int days)
    {
        return rentPerDay * days;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Vehicle Type: Bike");
        base.DisplayInfo();
    }
}
