using System;

class VolumeOfEarth
{
    static void Main()
    {
        double radiusKm = 6378;
        double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        double volumeMiles = volumeKm * Math.Pow(0.625, 3);

        Console.WriteLine(
            "The volume of earth in cubic kilometers is " + volumeKm + " and cubic miles is " + volumeMiles);
    }
}
