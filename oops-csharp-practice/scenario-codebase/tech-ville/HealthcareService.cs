// ======================================
// UC-6: Healthcare Service
// Inherits from Service
// ======================================
using System;

public class HealthcareService : Service
{
    private int availableDoctors;

    // constructor
    public HealthcareService(double cost, int doctors)
        : base("Healthcare", cost)
    {
        this.availableDoctors = doctors;
    }

    // method specific to healthcare
    public void ShowHealthcareDetails()
    {
        DisplayService();   // base class method
        Console.WriteLine("Available Doctors: " + availableDoctors);
    }
}
