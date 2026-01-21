using System;

class AadharRadixSortWithSearch
{
    static void Main()
    {
        // Sample Aadhar numbers
        long[] aadharNumbers =
        {
            123456789012,
            123456789010,
            123456789011,
            223456789012,
            123456789015
        };

        // Scenario A: Sort using Radix Sort
        RadixSort(aadharNumbers);

        Console.WriteLine("Scenario A: Sorted Aadhar Numbers:");
        Print(aadharNumbers);

        // Scenario B: Search for a particular Aadhar number
        long searchNumber = 123456789011;
        int index = BinarySearch(aadharNumbers, searchNumber);

        Console.WriteLine("\nScenario B: Binary Search Result");
        if (index != -1)
            Console.WriteLine($"Aadhar {searchNumber} found at index {index}");
        else
            Console.WriteLine($"Aadhar {searchNumber} not found");

        // Scenario C: Stability is automatically preserved
        Console.WriteLine("\nScenario C: Same-prefix order preserved (stability check)");
        Print(aadharNumbers);
    }

    // ---------- RADIX SORT ----------
    static void RadixSort(long[] arr)
    {
        long max = GetMax(arr);

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(arr, exp);
        }
    }

    static void CountingSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        // Count occurrences of each digit
        for (int i = 0; i < n; i++)
        {
            int digit = (int)((arr[i] / exp) % 10);
            count[digit]++;
        }

        // Prefix sum for positions
        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        // Build output array (right → left for stability)
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // Copy back
        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    static long GetMax(long[] arr)
    {
        long max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];
        return max;
    }

    // ---------- BINARY SEARCH ----------
    static int BinarySearch(long[] arr, long target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    static void Print(long[] arr)
    {
        foreach (long num in arr)
            Console.WriteLine(num);
    }
}
