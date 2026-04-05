using System;

public class EducationService : Service
{
    private int availableSchools;

    public EducationService(double cost, int schools)
        : base("Education", cost)
    {
        this.availableSchools = schools;
    }

    public override void UseService()
    {
        Console.WriteLine("Education service used.");
    }

    public virtual void ShowEducationDetails()
    {
        DisplayService();
        Console.WriteLine("Available Schools: " + availableSchools);
    }
}
