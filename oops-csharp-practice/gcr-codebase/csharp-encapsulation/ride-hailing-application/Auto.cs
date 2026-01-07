class Auto : Vehicle
{
    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        double fare = distance * RatePerKm;
        return fare < 50 ? 50 : fare;
    }
}
