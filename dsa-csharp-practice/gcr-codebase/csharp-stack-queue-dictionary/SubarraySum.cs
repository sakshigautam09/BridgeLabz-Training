using System;
using System.Collections.Generic;

class SubarraySum
{
    static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        // Initialize map with sum 0 at index -1
        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (map.ContainsKey(sum))
            {
                foreach (int start in map[sum])
                {
                    Console.Write("Subarray: [");
                    for (int j = start + 1; j <= i; j++)
                        Console.Write(arr[j] + (j < i ? ", " : ""));
                    Console.WriteLine("]");
                }
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
    }

    static void Main()
    {
        int[] arr = { 3, 4, -7, 1, 2, -1, 6 };
        FindZeroSumSubarrays(arr);
    }
}
