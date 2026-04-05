using System;
class PetrolPump
{
    public int Petrol;
    public int DistanceToNext;

    public PetrolPump(int petrol, int distance)
    {
        Petrol = petrol;
        DistanceToNext = distance;
    }
}

class CircularTour
{
    // Method to find starting pump index
    public static int FindStartPump(PetrolPump[] pumps)
    {
        int n = pumps.Length;
        Queue<PetrolPump> queue = new Queue<PetrolPump>();
        int startIndex = 0;
        int extra = 0; // extra petrol
        int deficit = 0; // deficit

        // Initialize queue with all pumps
        foreach (var pump in pumps)
        {
            queue.Enqueue(pump);
        }

        for (int i = 0; i < n; i++)
        {
            extra += pumps[i].Petrol - pumps[i].DistanceToNext;

            if (extra < 0)
            {
                // Cannot start from current startIndex, move to next pump
                startIndex = i + 1;
                deficit += extra;
                extra = 0;
            }
        }

        // If total petrol >= total distance, tour is possible
        return (extra + deficit >= 0) ? startIndex : -1;
    }

    static void Main()
    {
        PetrolPump[] pumps = new PetrolPump[]
        {
            new PetrolPump(4, 6),
            new PetrolPump(6, 5),
            new PetrolPump(7, 3),
            new PetrolPump(4, 5)
        };

        int start = FindStartPump(pumps);
        if (start != -1)
            Console.WriteLine("Start the tour at pump index: " + start);
        else
            Console.WriteLine("No possible tour.");
    }
}
