//Create a Book class with attributes title, author, and price.
//Provide both default and parameterized constructors.
using System;
class Book
{
    public string title;
    public string author;
    public double price;

    // Default Constructor
    public Book()
    {
        title = "Ikigai";
        author = "Mark Manson";
        price = 0;
    }

    // Parameterized Constructor
    public Book(string t, string a, double p)
    {
        title = t;
        author = a;
        price = p;
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: ₹" + price);
    }
}
class BookClass
{
    static void Main()
    {
        Book b1 = new Book();   // Default constructor
        b1.DisplayBookDetails();

        Console.WriteLine();

        Book b2 = new Book("C", "Dennis Ritchie", 550);
        b2.DisplayBookDetails();
    }
}
