using System;
class Hotel
{
    public string guestName;
    public string roomType;
    public int nights;

    // Default Constructor
    public Hotel()
    {
        guestName = "JOHN";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized Constructor
    public Hotel(string name, string room, int n)
    {
        guestName = name;
        roomType = room;
        nights = n;
    }

    // Copy Constructor
    public Hotel(Hotel h)
    {
        guestName = h.guestName;
        roomType = h.roomType;
        nights = h.nights;
    }

    public void Display()
    {
        Console.WriteLine($"Guest: {guestName}, Room: {roomType}, Nights: {nights}");
    }
}
class HotelBookingApp
{
    static void Main()
    {
        Hotel b1 = new Hotel();
        Hotel b2 = new Hotel("Amit", "Deluxe", 3);
        Hotel b3 = new Hotel(b2);

        b1.Display();
        b2.Display();
        b3.Display();
    }
}
