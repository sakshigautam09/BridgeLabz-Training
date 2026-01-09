using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static int[] MaxSlidingWindow(int[] arr, int k)
    {
        int n = arr.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            while (dq.Count > 0 && dq.First.Value <= i - k)
            {
                dq.RemoveFirst();
            }

            while (dq.Count > 0 && arr[dq.Last.Value] <= arr[i])
            {
                dq.RemoveLast();
            }

            dq.AddLast(i);

            if (i >= k - 1)
            {
                result[i - k + 1] = arr[dq.First.Value];
            }
        }

        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] maxWin = MaxSlidingWindow(arr, k);

        for (int i = 0; i < maxWin.Length; i++)
        {
            Console.Write(maxWin[i] + " ");
        }
    }
}
