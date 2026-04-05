using System;
class Book
{
    // static variable (shared by all books)
    public static string LibraryName = "Central Library";

    // readonly variable
    public readonly string ISBN;
    // instance variables
    public string Title;
    public string Author;

    // Constructor using 'this'
    public Book(string isbn, string title, string author)
    {
        this.ISBN = isbn;        // readonly assigned once
        this.Title = title;     // resolves ambiguity
        this.Author = author;   // resolves ambiguity
    }

    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // instance method
    public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}
class LibraryManagementSystem
{
    static void Main()
    {
        Book b1 = new Book("ISBN101", "C# Programming", "Herbert Schildt");
        Book b2 = new Book("ISBN102", "Java Basics", "James Gosling");

        Console.WriteLine();

        // Static method call
        Book.DisplayLibraryName();
        Console.WriteLine();

        // Using 'is' operator
        if (b1 is Book)
        {
            Console.WriteLine("b1 is a Book object");
            b1.DisplayBookDetails();
        }

        Console.WriteLine();

        if (b2 is Book)
        {
            Console.WriteLine("b2 is a Book object");
            b2.DisplayBookDetails();
        }
    }
}
