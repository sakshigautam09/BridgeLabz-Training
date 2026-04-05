class TrafficManager
{
    private Roundabout roundabout;
    private VehicleQueue waitingQueue;

    public TrafficManager(int roundaboutSize, int queueSize)
    {
        roundabout = new Roundabout(roundaboutSize);
        waitingQueue = new VehicleQueue(queueSize);
    }

    public void VehicleArrives(int number)
    {
        if (!roundabout.IsFull())
        {
            roundabout.AddVehicle(number);
        }
        else
        {
            waitingQueue.Enqueue(number);
        }
    }

    public void VehicleExits()
    {
        roundabout.RemoveVehicle();

        int nextVehicle = waitingQueue.Dequeue();
        if (nextVehicle != -1)
        {
            roundabout.AddVehicle(nextVehicle);
        }
    }

    public void ShowStatus()
    {
        roundabout.Display();
    }
}
