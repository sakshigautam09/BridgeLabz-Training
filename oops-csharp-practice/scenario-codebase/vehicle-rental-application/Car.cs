public class Car : Vehicle
{
    public Car(string vehicleNumber)
        : base(vehicleNumber, 800) { }

    public override double CalculateRent(int days)
    {
        return (rentPerDay * days) + 500; // service charge
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Vehicle Type: Car");
        base.DisplayInfo();
    }
}
