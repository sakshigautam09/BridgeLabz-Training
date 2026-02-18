using System;

// Interface
public interface IServiceOperations
{
    void DisplayService();
}

// Abstract base class
public abstract class Service : IServiceOperations
{
    protected string serviceName;
    protected double serviceCost;

    // static variable
    public static int TotalServices = 0;

    // constructor using this keyword
    public Service(string serviceName, double serviceCost)
    {
        this.serviceName = serviceName;
        this.serviceCost = serviceCost;
        TotalServices++;
    }

    public double Cost
    {
        get { return serviceCost; }
        set { serviceCost = value; }
    }

    public abstract void UseService();

    public virtual void DisplayService()
    {
        Console.WriteLine("Service: " + serviceName);
        Console.WriteLine("Cost: " + serviceCost);
    }

    // Factory pattern
    public static Service CreateService(string type, double cost, int value)
    {
        if (type.ToLower() == "healthcare")
            return new HealthcareService(cost, value);

        if (type.ToLower() == "education")
            return new EducationService(cost, value);

        return null;
    }
}
