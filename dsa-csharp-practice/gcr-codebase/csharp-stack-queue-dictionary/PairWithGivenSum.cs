using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static bool HasPairWithSum(int[] arr, int target)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];
            if (map.ContainsKey(complement))
            {
                Console.WriteLine("Pair found: (" + arr[i] + ", " + complement + ")");
                return true;
            }

            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = true;
        }

        Console.WriteLine("No pair found");
        return false;
    }

    static void Main()
    {
        int[] arr = { 1, 4, 6, 8, 3 };
        int target = 10;
        HasPairWithSum(arr, target);
    }
}
