using System;

public sealed class PremiumEducationService : EducationService
{
    private string smartClassFeature;

    public PremiumEducationService(double cost, int schools, string feature)
        : base(cost, schools)
    {
        this.smartClassFeature = feature;
    }

    public override void UseService()
    {
        base.UseService();
        Console.WriteLine("Premium education features activated.");
    }

    public void ShowPremiumEducation()
    {
        base.ShowEducationDetails();
        Console.WriteLine("Smart Class Feature: " + smartClassFeature);
    }
}
