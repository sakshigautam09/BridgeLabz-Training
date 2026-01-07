using System;

public class Truck : Vehicle, IInsurable
{
    private string policyNumber;

    public Truck(string vehicleNumber, double rentalRate, string policyNumber)
        : base(vehicleNumber, "Truck", rentalRate)
    {
        this.policyNumber = policyNumber;
    }

    public override double CalculateRentalCost(int days)
    {
        // Trucks: 1.2x rental rate per day
        return RentalRate * days * 1.2;
    }

    public double CalculateInsurance()
    {
        // Trucks: 7% of rental rate per day
        return RentalRate * 0.07;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance Policy: " + policyNumber;
    }
}
