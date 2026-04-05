using System;

public class Bike : Vehicle, IInsurable
{
    private string policyNumber;

    public Bike(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, "Bike", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        // Bikes have a discount of 10% per day
        return RentalRate * days * 0.9;
    }

    public double CalculateInsurance()
    {
        // For bikes: flat 3% of rental rate per day
        return RentalRate * 0.03;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance Policy: " + policyNumber;
    }
}
