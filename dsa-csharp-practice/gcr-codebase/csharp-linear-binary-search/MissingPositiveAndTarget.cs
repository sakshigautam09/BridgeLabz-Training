using System;
class MissingPositiveAndTarget
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        // using linear search
        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine($"First missing positive integer: {missing}");

        // using binary search
        Console.Write("Enter target number to search: ");
        int targetIndex = BinarySearch(arr, target);

        if (targetIndex != -1)
            Console.WriteLine($"Target {target} found at index {targetIndex} in the sorted array.");
        else
            Console.WriteLine($"Target {target} not found in the array.");
    }

    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        // Replace negative numbers and zeros with n+1
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0)
                arr[i] = n + 1;
        }

        // Mark visited numbers as negative
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(arr[i]);
            if (num <= n)
            {
                arr[num - 1] = -Math.Abs(arr[num - 1]);
            }
        }

        // First positive index + 1 is the missing number
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
                return i + 1;
        }

        return n + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

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
