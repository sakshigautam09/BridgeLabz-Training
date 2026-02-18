public class Service
{
    protected string serviceName;
    protected double serviceCost;

    public Service(string name, double cost)
    {
        serviceName = name;
        serviceCost = cost;
    }

    public void DisplayService()
    {
        Console.WriteLine("Service: " + serviceName);
        Console.WriteLine("Cost: " + serviceCost);
    }
}
