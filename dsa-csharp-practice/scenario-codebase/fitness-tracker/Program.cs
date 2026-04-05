using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of users: ");
        int n = int.Parse(Console.ReadLine());

        FitnessTracker tracker = new FitnessTracker(n);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"\nEnter name of user {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter steps for {name}: ");
            int steps = int.Parse(Console.ReadLine());

            tracker.AddUser(name, steps);
        }
        
        tracker.BubbleSort();
        tracker.DisplayLeaderboard();
    }
}