using System;
using System.Collections.Generic;
public class ReverseQueue
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        Console.Write("Enter number of elements in the queue: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            queue.Enqueue(int.Parse(Console.ReadLine()));

        ReverseQueueFunction(queue);

        Console.WriteLine("Reversed Queue:");
        foreach (int item in queue)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void ReverseQueueFunction(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int front = queue.Dequeue();       // remove front
        ReverseQueueFunction(queue);    // reverse remaining
        queue.Enqueue(front);              // add front to back
    }
}
