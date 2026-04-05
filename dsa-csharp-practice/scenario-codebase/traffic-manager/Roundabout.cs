using System;

class Roundabout
{
    private Vehicle tail;
    private int count;
    private int capacity;

    public Roundabout(int capacity)
    {
        this.capacity = capacity;
        tail = null;
        count = 0;
    }

    public bool IsFull()
    {
        return count == capacity;
    }

    public void AddVehicle(int number)
    {
        if (IsFull())
        {
            Console.WriteLine("Roundabout is full");
            return;
        }

        Vehicle newVehicle = new Vehicle(number);

        if (tail == null)
        {
            tail = newVehicle;
            tail.Next = tail;
        }
        else
        {
            newVehicle.Next = tail.Next;
            tail.Next = newVehicle;
            tail = newVehicle;
        }

        count++;
        Console.WriteLine("Vehicle entered: " + number);
    }

    public void RemoveVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty");
            return;
        }

        Vehicle head = tail.Next;

        if (head == tail)
        {
            tail = null;
        }
        else
        {
            tail.Next = head.Next;
        }

        count--;
        Console.WriteLine("Vehicle exited: " + head.VehicleNumber);
    }

    public void Display()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty");
            return;
        }

        Vehicle temp = tail.Next;
        Console.Write("Roundabout: ");

        do
        {
            Console.Write(temp.VehicleNumber + " ");
            temp = temp.Next;
        } while (temp != tail.Next);

        Console.WriteLine();
    }
}
