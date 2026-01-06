using System;
class Program
{
    static void Main()
    {
        Customer customer1 = new Customer("Amit");

        Vehicle bike = new Bike("BIKE-101");
        Vehicle car = new Car("CAR-202");
        Vehicle truck = new Truck("TRUCK-303");

        customer1.RentVehicle(bike, 2);
        customer1.RentVehicle(car, 3);
        customer1.RentVehicle(truck, 1);

        Console.WriteLine("\nRental Process Completed.");
    }
}
