using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    static Stack<int> stack1 = new Stack<int>();
    static Stack<int> stack2 = new Stack<int>();

    static void Enqueue(int x)
    {
        stack1.Push(x);
    }

    static int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }

        return stack2.Pop();
    }

    static void Main()
    {
        Enqueue(10);
        Enqueue(20);
        Enqueue(30);
        Console.WriteLine(Dequeue()); // 10
        Console.WriteLine(Dequeue()); // 20
        Enqueue(40);
        Console.WriteLine(Dequeue()); // 30
    }
}
