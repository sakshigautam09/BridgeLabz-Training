using System;
public static class UnitConvertor_1
{
    public static double ConvertKmToMiles(double km)
    {
        double kmToMiles = 0.621371;
        return km * kmToMiles;
    }
    public static double ConvertMilesToKm(double miles)
    {
        double milesToKm = 1.60934;
        return miles * milesToKm;
    }
    public static double ConvertMetersToFeet(double meters)
    {
        double metersToFeet = 3.28084;
        return meters * metersToFeet;
    }
    public static double ConvertFeetToMeters(double feet)
    {
        double feetToMeters = 0.3048;
        return feet * feetToMeters;
    }
}
