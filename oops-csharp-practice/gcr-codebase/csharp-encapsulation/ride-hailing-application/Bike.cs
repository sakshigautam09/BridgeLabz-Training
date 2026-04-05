class Bike : Vehicle
{
    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 0.9;
    }
}
