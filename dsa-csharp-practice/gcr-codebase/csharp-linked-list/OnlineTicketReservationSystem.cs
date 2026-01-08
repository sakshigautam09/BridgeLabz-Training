using System;

// Circular Linked List Node
class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public string BookingTime;

    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, int seat, string time)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
        Next = null;
    }
}

// Circular Linked List
class TicketReservationSystem
{
    private TicketNode head = null;
    private TicketNode tail = null;

    // Add ticket at end
    public void AddTicket(int id, string customer, string movie, int seat, string time)
    {
        TicketNode newTicket = new TicketNode(id, customer, movie, seat, time);

        if (head == null)
        {
            head = tail = newTicket;
            newTicket.Next = head; // circular link
            return;
        }

        tail.Next = newTicket;
        newTicket.Next = head;
        tail = newTicket;
    }

    // Remove ticket by ID
    public void RemoveTicket(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        TicketNode curr = head;
        TicketNode prev = tail;

        while (curr.Next != head)
        {
            if (curr.TicketId == id)
                break;

            prev = curr;
            curr = curr.Next;
        }

        if (curr.TicketId != id)
        {
            Console.WriteLine("Ticket not found.");
            return;
        }

        if (curr == head && curr == tail)
        {
            head = tail = null;
        }
        else
        {
            prev.Next = curr.Next;
            if (curr == head)
                head = curr.Next;
            if (curr == tail)
                tail = prev;
        }

        Console.WriteLine("Ticket removed.");
    }

    // Display tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Console.WriteLine("\n--- Booked Tickets ---");
        TicketNode temp = head;

        while (true)
        {
            DisplayTicket(temp);
            temp = temp.Next;
            if (temp == head)
                break;
        }
    }

    // Search by customer or movie
    public void Search(string keyword)
    {
        if (head == null)
            return;

        TicketNode temp = head;
        bool found = false;

        while (true)
        {
            if (temp.CustomerName.Equals(keyword, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
            {
                DisplayTicket(temp);
                found = true;
            }

            temp = temp.Next;
            if (temp == head)
                break;
        }

        if (!found)
            Console.WriteLine("No matching ticket found.");
    }

    // Count tickets
    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        int count = 0;
        TicketNode temp = head;

        while (true)
        {
            count++;
            temp = temp.Next;
            if (temp == head)
                break;
        }

        Console.WriteLine($"Total Tickets Booked: {count}");
    }

    private void DisplayTicket(TicketNode t)
    {
        Console.WriteLine($"ID:{t.TicketId}, Customer:{t.CustomerName}, Movie:{t.MovieName}, Seat:{t.SeatNumber}, Time:{t.BookingTime}");
    }
}

// Main
class OnlineTicketReservationSystem
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(1, "Amit", "Avatar", 12, "10:00 AM");
        system.AddTicket(2, "Riya", "Avatar", 15, "10:05 AM");
        system.AddTicket(3, "Neha", "Inception", 18, "10:10 AM");

        system.DisplayTickets();

        system.Search("Avatar");

        system.RemoveTicket(2);
        system.DisplayTickets();

        system.CountTickets();
    }
}
