using System;
class Vehicle
{
    // static variable
    public static double RegistrationFee = 1500;

    // readonly variable (cannot be changed)
    public readonly string RegistrationNumber;

    // instance variables
    public string OwnerName;
    public string VehicleType;

    // constructor
    public Vehicle(string registrationNumber, string ownerName, string vehicleType)
    {
        this.RegistrationNumber = registrationNumber;
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
    }

    // static method to update registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    // instance method to display details
    public void DisplayDetails()
    {
        Console.WriteLine($"Reg No: {RegistrationNumber}, Owner: {OwnerName}, Type: {VehicleType}, Fee: {RegistrationFee}");
    }
}

class VehicleRegistrationSystem
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("UP85AB1234", "Rahul", "Car");
        Vehicle v2 = new Vehicle("UP85XY5678", "Anita", "Bike");

        // using is operator
        if (v1 is Vehicle)
        {
            v1.DisplayDetails();
        }

        UpdateRegistrationFee(2000);

        v1.DisplayDetails();
        v2.DisplayDetails();
    }
}
