using System;
class User : Person
{
    public User(string name) : base(name) { }
    public override void Menu(TicketService service)
    {
        while (true)
        {
            Console.WriteLine("--- User Menu ---");
            Console.WriteLine("1. View Movies");
            Console.WriteLine("2. Book Tickets");
            Console.WriteLine("3. Logout");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    service.ShowMoviesWithIndex();
                    break;
                case "2":
                    service.ShowMoviesWithIndex();
                    Console.Write("Enter movie index to book: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        Console.Write("Enter number of tickets: ");
                        if (int.TryParse(Console.ReadLine(), out int ticketCount))
                        {
                            bool success = service.BookTicketsByIndex(index, ticketCount);
                            if (success)
                                Console.WriteLine("Booking successful!");
                            else
                                Console.WriteLine("Not enough tickets");
                        }
                        else
                        {
                            Console.WriteLine("Invalid ticket number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index!");
                    }
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
