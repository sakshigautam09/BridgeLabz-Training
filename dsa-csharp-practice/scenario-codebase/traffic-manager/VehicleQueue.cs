class VehicleQueue
{
    private int[] queue;
    private int front, rear, size;

    public VehicleQueue(int size)
    {
        this.size = size;
        queue = new int[size];
        front = 0;
        rear = -1;
    }

    public bool IsEmpty()
    {
        return front > rear;
    }

    public bool IsFull()
    {
        return rear == size - 1;
    }

    public void Enqueue(int vehicle)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue Overflow");
            return;
        }

        queue[++rear] = vehicle;
        Console.WriteLine("Vehicle waiting: " + vehicle);
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }

        return queue[front++];
    }
}
