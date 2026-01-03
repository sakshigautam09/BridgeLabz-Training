using System;
class Vehicle
{
    // Instance variables
    public string ownerName;
    public string vehicleType;

    // Class variable
    public static double registrationFee = 5000;

    // Constructor
    public Vehicle(string owner, string type)
    {
        ownerName = owner;
        vehicleType = type;
    }

    // Instance method
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: ₹" + registrationFee);
    }

    // Class (static) method
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}
class VehicleRegistration
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Rahul", "Car");
        Vehicle v2 = new Vehicle("Anita", "Bike");

        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdating Registration Fee...\n");
        Vehicle.UpdateRegistrationFee(6500);

        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();
    }
}
