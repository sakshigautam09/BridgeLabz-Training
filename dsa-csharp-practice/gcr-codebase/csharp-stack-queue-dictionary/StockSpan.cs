using System;
using System.Collections.Generic;

class StockSpan
{
    static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> s = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (s.Count > 0 && prices[s.Peek()] <= prices[i])
            {
                s.Pop();
            }

            if (s.Count == 0)
            {
                span[i] = i + 1;
            }
            else
            {
                span[i] = i - s.Peek();
            }

            s.Push(i);
        }

        return span;
    }

    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        for (int i = 0; i < span.Length; i++)
        {
            Console.Write(span[i] + " ");
        }
    }
}
