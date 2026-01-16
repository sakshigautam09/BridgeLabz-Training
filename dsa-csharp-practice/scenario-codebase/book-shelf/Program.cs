class Program
{
    static void Main()
    {
        Console.Write("Enter max genres: ");
        int maxGenres = int.Parse(Console.ReadLine());

        Library library = new Library(maxGenres);

        while (true)
        {
            Console.WriteLine("\n1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Display Library");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 4) break;

            if (choice == 3)
            {
                library.DisplayLibrary();
                continue;
            }

            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            if (choice == 1)
                library.AddBook(genre, title);
            else if (choice == 2)
                library.RemoveBook(genre, title);
        }
    }
}
