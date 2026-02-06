class SeniorPassenger : Passenger
{
    public override double CalculateFare()
    {
        return 1000 - (1000 * 0.4);
    }
}