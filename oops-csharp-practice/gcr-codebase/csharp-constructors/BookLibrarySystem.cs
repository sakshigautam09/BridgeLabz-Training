using System;
class Book
{
    public string ISBN;         // public
    protected string title;     // protected
    private string author;      // private

    // Constructor
    public Book(string isbn, string t, string a)
    {
        ISBN = isbn;
        title = t;
        author = a;
    }

    // Public methods to access private member
    public void SetAuthor(string a)
    {
        author = a;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void DisplayBook()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

// Subclass for protected
class EBook : Book
{
    public double fileSize;
    public EBook(string isbn, string t, string a, double size)
        : base(isbn, t, a)
    {
        fileSize = size;
    }

    public void DisplayEBook()
    {
        Console.WriteLine("ISBN: " + ISBN);   // public
        Console.WriteLine("Title: " + title); // protected
        Console.WriteLine("File Size: " + fileSize + " MB");
        Console.WriteLine("Author: " + GetAuthor()); // private accessed via public method
    }
}
class BookLibrarySystem
{
    static void Main()
    {
        Book b1 = new Book("ISBN001", "C# Programming", "Herbert Schildt");
        b1.DisplayBook();

        Console.WriteLine();

        EBook eb = new EBook("ISBN002", "Java Programming", "James Gosling", 15.5);
        eb.DisplayEBook();
    }
}
