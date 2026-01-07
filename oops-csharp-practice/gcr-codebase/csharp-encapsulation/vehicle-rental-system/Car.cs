using System;

public class Car : Vehicle, IInsurable
{
    private string policyNumber;

    public Car(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, "Car", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    public double CalculateInsurance()
    {
        // For cars: flat 5% of rental rate per day
        return RentalRate * 0.05;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance Policy: " + policyNumber;
    }
}
