using System;
using System.Text.RegularExpressions;

public class FlightUtil
{
    public bool validateFlightNumber(String flightNumber)
    {
        // Format: FL-XXXX where XXXX is 1000–9999
        if (!Regex.IsMatch(flightNumber, "^FL-[1-9][0-9]{3}$"))
        {
            throw new InvalidFlightException("The flight number " + flightNumber + " is invalid");
        }
        return true;
    }

    public bool validateFlightName(String flightName)
    {
        if (!(flightName.Equals("SpiceJet") ||
              flightName.Equals("Vistara") ||
              flightName.Equals("IndiGo") ||
              flightName.Equals("Air Arabia")))
        {
            throw new InvalidFlightException("The flight name " + flightName + " is invalid");
        }
        return true;
    }

    public bool validatePassengerCount(int passengerCount, String flightName)
    {
        int maxCapacity = 0;

        if (flightName.Equals("SpiceJet"))
            maxCapacity = 396;
        else if (flightName.Equals("Vistara"))
            maxCapacity = 615;
        else if (flightName.Equals("IndiGo"))
            maxCapacity = 230;
        else if (flightName.Equals("Air Arabia"))
            maxCapacity = 130;

        if (passengerCount <= 0 || passengerCount > maxCapacity)
        {
            throw new InvalidFlightException(
                "The passenger count " + passengerCount + " is invalid for " + flightName);
        }
        return true;
    }

    public double calculateFuelToFillTank(String flightName, double currentFuelLevel)
    {
        double capacity = 0;

        if (flightName.Equals("SpiceJet"))
            capacity = 200000;
        else if (flightName.Equals("Vistara"))
            capacity = 300000;
        else if (flightName.Equals("IndiGo"))
            capacity = 250000;
        else if (flightName.Equals("Air Arabia"))
            capacity = 150000;

        if (currentFuelLevel < 0 || currentFuelLevel > capacity)
        {
            throw new InvalidFlightException("Invalid fuel level for " + flightName);
        }

        return capacity - currentFuelLevel;
    }
}
