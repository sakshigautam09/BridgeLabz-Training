using System;
class BusRoute
{
    // Public data members
    public int totalDistance = 0;
    public int stopCount = 0;

    public void AddStop(int distance)
    {
        totalDistance += distance;
        stopCount++;
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Stop Number: " + stopCount);
        Console.WriteLine("Total Distance Covered: " + totalDistance + " km");
    }
}
class BusRouteDistanceTracker
{
    static void Main()
    {
        BusRoute route = new BusRoute();
        string chooseOption;

        Console.WriteLine("Bus Route Distance Tracker");

        while (true)
        {
            Console.Write("\nEnter distance to next stop (in km): ");
            int distance = int.Parse(Console.ReadLine());

            route.AddStop(distance);
            route.DisplayStatus();

            Console.Write("Do you want to get off? (yes/no): ");
            chooseOption = Console.ReadLine().ToLower();

            if (chooseOption == "yes")
            {
                Console.WriteLine("\nPassenger got off.");
                Console.WriteLine("Total Stops Travelled: " + route.stopCount);
                Console.WriteLine("Final Distance Travelled: " + route.totalDistance + " km");
                break;
            }
        }
    }
}
