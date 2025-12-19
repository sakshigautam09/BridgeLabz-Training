using System;

class TripDetails
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter fromCity: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter viaCity: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter toCity: ");
        string toCity = Console.ReadLine();

        Console.Write("FromToVia distance: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("ViaToFinalCity distance: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time taken: ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The results of the trip are: {name}, total distance {fromToVia + viaToFinalCity} miles, time taken {timeTaken} hours");
    }
}
