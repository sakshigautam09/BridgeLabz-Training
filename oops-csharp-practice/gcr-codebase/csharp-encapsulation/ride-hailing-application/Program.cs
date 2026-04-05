using System;
class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car("C101", "Alice", 20);
        vehicles[1] = new Bike("B201", "Bob", 10);
        vehicles[2] = new Auto("A301", "Charlie", 15);

        vehicles[0].UpdateLocation("City");
        vehicles[1].UpdateLocation("Railway Station");
        vehicles[2].UpdateLocation("Airport");

        Console.WriteLine("=== Ride Hailing Application ===\n");

        double distance = 10;

        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].GetVehicleDetails();
            Console.WriteLine("Current Location: " + vehicles[i].GetCurrentLocation());
            Console.WriteLine("Total Fare: " + vehicles[i].CalculateFare(distance));
            Console.WriteLine();
        }
    }
}
