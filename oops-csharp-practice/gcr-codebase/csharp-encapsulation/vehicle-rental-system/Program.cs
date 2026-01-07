using System;
class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[4];

        Car car1 = new Car("CAR101", 2000, "CARPOL123");
        Bike bike1 = new Bike("BIKE201", 500, "BIKEPOL456");
        Truck truck1 = new Truck("TRK301", 5000, "TRKPOL789");
        Car car2 = new Car("CAR102", 2500, "CARPOL124");

        vehicles[0] = car1;
        vehicles[1] = bike1;
        vehicles[2] = truck1;
        vehicles[3] = car2;

        Console.WriteLine("=== Vehicle Rental and Insurance Details ===");
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].DisplayDetails();

            int days = 3; 
            double rentalCost = vehicles[i].CalculateRentalCost(days);
            Console.WriteLine("Rental Cost for " + days + " days: " + rentalCost);

            IInsurable insurableVehicle = vehicles[i] as IInsurable;
            if (insurableVehicle != null)
            {
                double insurance = insurableVehicle.CalculateInsurance();
                Console.WriteLine("Insurance: " + insurance);
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
            }
        }
    }
}
