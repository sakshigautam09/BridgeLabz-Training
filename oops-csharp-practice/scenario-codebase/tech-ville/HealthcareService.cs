using System;

public class HealthcareService : Service
{
    private int availableDoctors;

    public HealthcareService(double cost, int doctors)
        : base("Healthcare", cost)
    {
        this.availableDoctors = doctors;
    }

    public override void UseService()
    {
        Console.WriteLine("Healthcare service used.");
    }

    public virtual void ShowHealthcareDetails()
    {
        DisplayService();
        Console.WriteLine("Available Doctors: " + availableDoctors);
    }
}
