using System;
using System.Diagnostics;
class LinearVSBinary
{
    static void Main()
    {
        int n = 10000;
        int[] data = new int[n];

        for (int i = 0; i < n; i++)
        {
            data[i] = i;
        }

        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());

        // Linear Search 
        Stopwatch sw = Stopwatch.StartNew();

        int linearIdx = LinearSearch(data, target);

        sw.Stop();
        Console.WriteLine("Linear Search:");
        Console.WriteLine("Index Found: " + linearIdx);
        Console.WriteLine("Time Taken: " + sw.Elapsed.TotalMilliseconds + " ms");
        Console.WriteLine();

        // Binary Search
        sw.Restart();
        int binaryIdx = BinarySearch(data, target);

        sw.Stop();
        Console.WriteLine("Binary Search:");
        Console.WriteLine("Index Found: " + binaryIdx);
        Console.WriteLine("Time Taken: " + sw.Elapsed.TotalMilliseconds + " ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
