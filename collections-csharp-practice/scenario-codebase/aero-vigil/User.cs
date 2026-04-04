using System;

public class User
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter flight details");
            string input = Console.ReadLine();

            string[] data = input.Split(':');

            string flightNumber = data[0];
            string flightName = data[1];
            int passengerCount = int.Parse(data[2]);
            double currentFuelLevel = double.Parse(data[3]);

            FlightUtil util = new FlightUtil();

            util.validateFlightNumber(flightNumber);
            util.validateFlightName(flightName);
            util.validatePassengerCount(passengerCount, flightName);

            double fuelRequired = util.calculateFuelToFillTank(flightName, currentFuelLevel);

            Console.WriteLine("Fuel required to fill the tank: " + fuelRequired + " liters");
        }
        catch (InvalidFlightException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception)
        {
            // Handles format issues like wrong input type
            Console.WriteLine("Invalid input format");
        }
    }
}
