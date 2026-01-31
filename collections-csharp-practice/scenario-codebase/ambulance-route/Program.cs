using System;
class Program
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        // Create circular route
        route.addUnit("Emergency", false);
        route.addUnit("Radiology", false);
        route.addUnit("Surgery", true);
        route.addUnit("ICU", false);

        Console.WriteLine("Hospital Route:");
        route.displayRoute();

        Console.WriteLine("\nFinding nearest available unit:");
        route.findAvailableUnit();

        Console.WriteLine("\nRemoving Surgery (maintenance)");
        route.removeUnit("Surgery");

        Console.WriteLine("\nUpdated Route:");
        route.displayRoute();

        Console.WriteLine("\nFinding nearest available unit:");
        route.findAvailableUnit();
    }
}
