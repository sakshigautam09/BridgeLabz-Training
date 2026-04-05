public class Customer
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        Console.WriteLine($"\nCustomer: {name}");
        vehicle.DisplayInfo();

        double rent = vehicle.CalculateRent(days);
        Console.WriteLine($"Days: {days}");
        Console.WriteLine($"Total Rent: ₹{rent}");
    }
}
