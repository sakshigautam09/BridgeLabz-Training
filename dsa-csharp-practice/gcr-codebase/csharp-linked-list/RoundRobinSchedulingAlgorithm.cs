using System;
// Node of Circular Linked List
class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public int WaitingTime;
    public int TurnAroundTime;

    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        WaitingTime = 0;
        TurnAroundTime = 0;
        Next = null;
    }
}

// Circular Linked List Scheduler
class RoundRobinScheduler
{
    private ProcessNode head = null;
    private ProcessNode tail = null;

    // Add process at end
    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode newNode = new ProcessNode(id, burst, priority);

        if (head == null)
        {
            head = tail = newNode;
            newNode.Next = head; // circular link
            return;
        }

        tail.Next = newNode;
        newNode.Next = head;
        tail = newNode;
    }

    // Remove process by ID
    private void RemoveProcess(int id)
    {
        if (head == null)
            return;

        ProcessNode curr = head;
        ProcessNode prev = tail;

        while (curr.Next != head)
        {
            if (curr.ProcessId == id)
                break;

            prev = curr;
            curr = curr.Next;
        }

        // Check last node
        if (curr.ProcessId != id)
            return;

        if (curr == head && curr == tail)
        {
            head = tail = null;
        }
        else
        {
            prev.Next = curr.Next;
            if (curr == head)
                head = curr.Next;
            if (curr == tail)
                tail = prev;
        }
    }

    // Display processes
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Console.Write("Queue: ");
        ProcessNode temp = head;

        while (true)
        {
            Console.Write($"P{temp.ProcessId} ");
            temp = temp.Next;
            if (temp == head)
                break;
        }
        Console.WriteLine();
    }

    // Round Robin Simulation
    public void Simulate(int timeQuantum)
    {
        int time = 0;
        int completed = 0;
        int totalProcesses = CountProcesses();

        ProcessNode curr = head;

        while (completed < totalProcesses)
        {
            if (curr.RemainingTime > 0)
            {
                if (curr.RemainingTime > timeQuantum)
                {
                    time += timeQuantum;
                    curr.RemainingTime -= timeQuantum;
                }
                else
                {
                    time += curr.RemainingTime;
                    curr.RemainingTime = 0;

                    curr.TurnAroundTime = time;
                    curr.WaitingTime = curr.TurnAroundTime - curr.BurstTime;
                    completed++;
                }

                DisplayProcesses();
            }

            curr = curr.Next;
        }

        CalculateAverageTime();
    }

    private int CountProcesses()
    {
        if (head == null)
            return 0;

        int count = 0;
        ProcessNode temp = head;

        while (true)
        {
            count++;
            temp = temp.Next;
            if (temp == head)
                break;
        }

        return count;
    }

    // Calculate average waiting & turnaround time
    private void CalculateAverageTime()
    {
        double totalWT = 0;
        double totalTAT = 0;
        int count = 0;

        ProcessNode temp = head;

        while (true)
        {
            totalWT += temp.WaitingTime;
            totalTAT += temp.TurnAroundTime;
            count++;

            temp = temp.Next;
            if (temp == head)
                break;
        }

        Console.WriteLine($"\nAverage Waiting Time = {totalWT / count}");
        Console.WriteLine($"Average Turnaround Time = {totalTAT / count}");
    }
}

// Main
class RoundRobinSchedulingAlgorithm
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        Console.WriteLine("Initial Process Queue:");
        scheduler.DisplayProcesses();

        Console.WriteLine("\nRound Robin Scheduling:");
        scheduler.Simulate(3);
    }
}
