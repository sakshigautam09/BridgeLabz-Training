using System;
class Program
{
    static void Main()
    {
        ICinemaService cinemaService = new CinemaUtility();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nCinemaTime: Movie Schedule Manager");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            int chooseOption;

            // Validate menu input
            if (!int.TryParse(input, out chooseOption))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (chooseOption)
            {
                case 1:
                    Console.Write("Enter movie title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter show time (HH:mm): ");
                    string time = Console.ReadLine();

                    cinemaService.AddMovie(title, time);
                    break;

                case 2:
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    cinemaService.SearchMovie(keyword);
                    break;

                case 3:
                    cinemaService.DisplayAllMovies();
                    break;

                case 4:
                    exit = true;
                    Console.WriteLine("Exiting CinemaTime. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
