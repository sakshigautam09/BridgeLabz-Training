using System;
class Movie
{
    public string Name { get; private set; }
    public int TotalTickets { get; private set; }
    public int TicketsAvailable { get; private set; }

    public Movie(string name, int totalTickets)
    {
        this.Name = name;
        this.TotalTickets = totalTickets;
        this.TicketsAvailable = totalTickets;
    }
    public bool BookTickets(int count)
    {
        if (count <= TicketsAvailable)
        {
            TicketsAvailable -= count;
            return true;
        }
        return false;
    }

    public void ShowInfo(int index)
    {
        Console.WriteLine($"{index}. {Name} - Tickets Available: {TicketsAvailable}");
    }
}
