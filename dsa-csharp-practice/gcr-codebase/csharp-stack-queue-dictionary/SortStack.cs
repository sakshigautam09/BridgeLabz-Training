using System;
using System.Collections.Generic;

class SortStackRecursion
{
    static void SortedInsert(Stack<int> s, int x)
    {
        if (s.Count == 0 || x > s.Peek())
        {
            s.Push(x);
            return;
        }

        int temp = s.Pop();
        SortedInsert(s, x);
        s.Push(temp);
    }

    static void SortStack(Stack<int> s)
    {
        if (s.Count > 0)
        {
            int x = s.Pop();
            SortStack(s);
            SortedInsert(s, x);
        }
    }

    static void Main()
    {
        Stack<int> s = new Stack<int>();
        s.Push(3);
        s.Push(1);
        s.Push(4);
        s.Push(2);

        SortStack(s);

        while (s.Count > 0)
        {
            Console.Write(s.Pop() + " "); // 4 3 2 1
        }
    }
}
