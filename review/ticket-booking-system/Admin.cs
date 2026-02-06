using System;
class Admin : Person
{
    public Admin(string name) : base(name) { }
    public override void Menu(TicketService service)
    {
        while (true)
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. View Movies");
            Console.WriteLine("3. Logout");
            Console.WriteLine("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Movie Name: ");
                    string movieName = Console.ReadLine();
                    Console.Write("Enter Total Tickets: ");
                    if (int.TryParse(Console.ReadLine(), out int totalTickets))
                    {
                        service.AddMovie(new Movie(movieName, totalTickets));
                        Console.WriteLine("Movie added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid ticket number!");
                    }
                    break;

                case "2":
                    service.ShowMoviesWithIndex();
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
