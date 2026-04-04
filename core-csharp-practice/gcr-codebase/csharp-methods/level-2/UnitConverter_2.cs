using System;

public static class UnitConvertor_2
{
    public static double ConvertYardsToFeet(double yards)
    {
        double yardsTofeet = 3;
        return yards * yardsTofeet;
    }
    public static double ConvertFeetToYards(double feet)
    {
        double feetToYards = 0.333333;
        return feet * feetToYards;
    }
    public static double ConvertMetersToInches(double meters)
    {
        double metersToInches = 39.3701;
        return meters * metersToInches;
    }
    public static double ConvertInchesToMeters(double inches)
    {
        double inchesToMeters = 0.0254;
        return inches * inchesToMeters;
    }
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inchesToCm = 2.54;
        return inches * inchesToCm;
    }
}
