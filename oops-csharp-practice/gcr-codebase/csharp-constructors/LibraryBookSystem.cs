using System;
class Book
{
    public string title;
    public string author;
    public double price;
    public bool availability;

    public Book(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
        availability = true;
    }

    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Price: ₹{price}, Available: {availability}");
    }
}
class LibraryBookSystem
{
    static void Main()
    {
        Book book = new Book("C", "Dennis Ritchie", 550);
        book.Display();

        book.BorrowBook();
        book.Display();
    }
}
