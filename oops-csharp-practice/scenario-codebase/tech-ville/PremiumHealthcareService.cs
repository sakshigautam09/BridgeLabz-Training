using System;

public sealed class PremiumHealthcareService : HealthcareService
{
    private string premiumFacility;

    public PremiumHealthcareService(double cost, int doctors, string facility)
        : base(cost, doctors)
    {
        this.premiumFacility = facility;
    }

    public override void UseService()
    {
        base.UseService();
        Console.WriteLine("Premium healthcare features activated.");
    }

    public void ShowPremiumHealthcare()
    {
        base.ShowHealthcareDetails();
        Console.WriteLine("Premium Facility: " + premiumFacility);
    }
}
