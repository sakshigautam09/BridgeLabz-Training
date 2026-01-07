class Car : Vehicle
{
    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 1.2;
    }
}
