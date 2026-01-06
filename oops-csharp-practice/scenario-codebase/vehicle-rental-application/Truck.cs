public class Truck : Vehicle
{
    public Truck(string vehicleNumber)
        : base(vehicleNumber, 1500) { }
    public override double CalculateRent(int days)
    {
        return (rentPerDay * days) + (days * 200); 
    }
    public override void DisplayInfo()
    {
        Console.WriteLine("Vehicle Type: Truck");
        base.DisplayInfo();
    }
}
