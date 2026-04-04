using System;
using System.Collections.Generic;
public class GenerateBinaryNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();

        queue.Enqueue("1");

        for (int i = 0; i < N; i++)
        {
            string front = queue.Dequeue();
            result.Add(front);

            // generate next numbers
            queue.Enqueue(front + "0");
            queue.Enqueue(front + "1");
        }

        Console.WriteLine("First " + N + " binary numbers:");
        foreach (string binary in result)
        {
            Console.Write(binary + " ");
        }
        Console.WriteLine();
    }
}
