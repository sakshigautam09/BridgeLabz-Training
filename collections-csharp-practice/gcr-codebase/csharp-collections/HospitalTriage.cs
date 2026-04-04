using System;
using System.Collections.Generic;

public class HospitalTriage
{
    public static void Main()
    {
        Console.Write("Enter number of patients: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter name of patient {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter severity of patient {i + 1} (higher = more severe): ");
            int severity = Convert.ToInt32(Console.ReadLine());

            pq.Enqueue(name, -severity);
        }

        Console.WriteLine("\nTreatment order:");
        while (pq.Count > 0)
        {
            string patient = pq.Dequeue();
            Console.WriteLine(patient);
        }
    }
}
