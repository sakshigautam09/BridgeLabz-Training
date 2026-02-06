// railway reservation system
// abstarct class passsenger
// normal and senior passenger
// sorting and searching 
// search by name
class Program
{
    static void Main()
    {
        RailwayReservation rr = new RailwayReservation();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Railway Reservation Menu ---");
            Console.WriteLine("1. Add Passenger");
            Console.WriteLine("2. Delete Passenger");
            Console.WriteLine("3. Display All Passengers");
            Console.WriteLine("4. Sort Passengers by PNR");
            Console.WriteLine("5. Search Passenger by PNR");
            Console.WriteLine("6. Search Passenger by Name");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            int chooseOption = int.Parse(Console.ReadLine());

            switch (chooseOption)
            {
                case 1: rr.AddPassenger(); break;
                case 2: rr.DeletePassenger(); break;
                case 3: rr.DisplayAll(); break;
                case 4: rr.SortByPNR(); rr.DisplayAll(); break;
                case 5: rr.SortByPNR(); rr.SearchByPNR(); break;
                case 6: rr.SearchByName(); break;
                case 7: exit = true; break;
                default: Console.WriteLine("Invalid Option choosed!"); break;
            }
        }
    }
}
