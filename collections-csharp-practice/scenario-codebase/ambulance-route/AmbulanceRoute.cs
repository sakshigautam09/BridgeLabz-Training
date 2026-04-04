class AmbulanceRoute
{
    private HospitalNode head;

    // Add unit to circular list
    public void addUnit(string name, bool available)
    {
        HospitalNode newNode = new HospitalNode(name, available);

        if (head == null)
        {
            head = newNode;
            newNode.next = head;
            return;
        }

        HospitalNode temp = head;
        while (temp.next != head)
        {
            temp = temp.next;
        }

        temp.next = newNode;
        newNode.next = head;
    }

    // Find nearest available unit
    public void findAvailableUnit()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available");
            return;
        }

        HospitalNode temp = head;

        do
        {
            if (temp.isAvailable)
            {
                Console.WriteLine("Patient redirected to: " + temp.unitName);
                return;
            }
            temp = temp.next;
        }
        while (temp != head);

        Console.WriteLine("No available unit at the moment");
    }

    // Remove unit under maintenance
    public void removeUnit(string unitName)
    {
        if (head == null)
            return;

        HospitalNode current = head;
        HospitalNode prev = null;

        do
        {
            if (current.unitName.Equals(unitName))
            {
                if (current == head)
                {
                    HospitalNode last = head;
                    while (last.next != head)
                        last = last.next;

                    head = head.next;
                    last.next = head;
                }
                else
                {
                    prev.next = current.next;
                }

                Console.WriteLine(unitName + " is under maintenance and removed");
                return;
            }

            prev = current;
            current = current.next;
        }
        while (current != head);
    }

    // Display route
    public void displayRoute()
    {
        if (head == null)
            return;

        HospitalNode temp = head;
        do
        {
            Console.Write(temp.unitName + " → ");
            temp = temp.next;
        }
        while (temp != head);

        Console.WriteLine("(Back to " + head.unitName + ")");
    }
}
