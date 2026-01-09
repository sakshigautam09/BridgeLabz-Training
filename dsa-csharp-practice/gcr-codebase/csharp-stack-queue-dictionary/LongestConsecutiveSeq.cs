using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    static int LongestConsecutive(int[] arr)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
            set.Add(arr[i]);

        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1)) // start of sequence
            {
                int current = num;
                int length = 1;

                while (set.Contains(current + 1))
                {
                    current += 1;
                    length += 1;
                }

                if (length > longest)
                    longest = length;
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine("Longest consecutive sequence length: " + LongestConsecutive(arr));
    }
}
