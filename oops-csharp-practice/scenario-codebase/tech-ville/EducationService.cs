// ======================================
// UC-6: Education Service
// Inherits from Service
// ======================================
using System;

public class EducationService : Service
{
    private int availableSchools;

    // constructor
    public EducationService(double cost, int schools)
        : base("Education", cost)
    {
        this.availableSchools = schools;
    }

    // education-specific behavior
    public void ShowEducationDetails()
    {
        DisplayService(); // from base class
        Console.WriteLine("Available Schools: " + availableSchools);
    }
}
