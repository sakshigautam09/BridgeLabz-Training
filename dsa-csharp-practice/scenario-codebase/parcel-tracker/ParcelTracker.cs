public class ParcelTracker
{
    private ParcelNode head;

    public ParcelTracker()
    {
        head = null;
    }

    public void AddStage(string stageName)
    {
        ParcelNode newStage = new ParcelNode(stageName);

        if (head == null)
        {
            head = newStage;
            return;
        }

        ParcelNode current = head;
        while (current.Next != null)
            current = current.Next;

        current.Next = newStage;
    }

    public void InsertCheckpoint(string afterStage, string checkpoint)
    {
        ParcelNode current = head;
        while (current != null && current.StageName != afterStage)
            current = current.Next;

        if (current == null)
        {
            Console.WriteLine($"Stage '{afterStage}' not found.");
            return;
        }

        ParcelNode newCheckpoint = new ParcelNode(checkpoint);
        newCheckpoint.Next = current.Next;
        current.Next = newCheckpoint;
    }

    public void RemoveStage(string stageName)
    {
        if (head == null) return;

        if (head.StageName == stageName)
        {
            head = head.Next;
            return;
        }

        ParcelNode current = head;
        while (current.Next != null && current.Next.StageName != stageName)
            current = current.Next;

        if (current.Next == null) return;

        current.Next = current.Next.Next;
    }

    public void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("No stages defined. Parcel not yet processed.");
            return;
        }

        ParcelNode current = head;
        Console.WriteLine("\nParcel Delivery Tracking:");
        while (current != null)
        {
            Console.WriteLine($"→ {current.StageName}");
            current = current.Next;
        }
    }
}