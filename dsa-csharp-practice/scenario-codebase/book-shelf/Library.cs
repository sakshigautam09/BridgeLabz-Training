class Library
{
    private CustomDictionary dict;

    public Library(int maxGenres)
    {
        dict = new CustomDictionary(maxGenres);
    }

    public void AddBook(string genre, string title)
    {
        GenreNode node = dict.Get(genre);

        if (node == null)
            node = dict.Add(genre);

        if (node.Books.AddBook(title))
            Console.WriteLine("Book added.");
        else
            Console.WriteLine("Duplicate book not allowed.");
    }

    public void RemoveBook(string genre, string title)
    {
        GenreNode node = dict.Get(genre);

        if (node == null)
        {
            Console.WriteLine("Genre not found.");
            return;
        }

        if (node.Books.RemoveBook(title))
            Console.WriteLine("Book removed.");
        else
            Console.WriteLine("Book not found.");
    }

    public void DisplayLibrary()
    {
        for (int i = 0; i < dict.Count; i++)
        {
            GenreNode node = dict.GetAll()[i];
            Console.WriteLine("\nGenre: " + node.Genre);
            node.Books.Display();
        }
    }
}
