using System;
using System.Collections.Generic;

class TwoSumProblem
{
    static int[] TwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];
            if (map.ContainsKey(complement))
            {
                Console.WriteLine("Indices: [" + map[complement] + ", " + i + "]");
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(arr[i]))
                map[arr[i]] = i;
        }

        Console.WriteLine("No solution found");
        return new int[0];
    }

    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;
        TwoSum(arr, target);
    }
}
