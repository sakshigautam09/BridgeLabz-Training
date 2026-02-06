using System;
class Program
{
    static void Main()
    {
        TicketService service = new TicketService(10); 
        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Admin Login");
            Console.WriteLine("2. User Login");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Admin Name: ");
                    string adminName = Console.ReadLine();
                    Admin admin = new Admin(adminName);
                    admin.Menu(service);
                    break;

                case "2":
                    Console.Write("Enter User Name: ");
                    string userName = Console.ReadLine();
                    User user = new User(userName);
                    user.Menu(service);
                    break;

                case "3":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
