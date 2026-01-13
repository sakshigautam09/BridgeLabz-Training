using System;
class FirstLastOccurance
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());

        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);

        if (first == -1)
            Console.WriteLine("Target not found in the array.");
        else
            Console.WriteLine($"First occurrence: {first}, Last occurrence: {last}");
    }

    static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1; 
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}
