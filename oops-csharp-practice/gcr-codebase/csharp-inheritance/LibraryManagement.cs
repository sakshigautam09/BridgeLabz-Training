using System;
class Book
{
    public string Title;
    public int PublicationYear;

    // Constructor
    public Book(string Title, int PublicationYear)
    {
        this.Title = Title;
        this.PublicationYear = PublicationYear;
    }

    // Method to display book info
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

class Author : Book
{
    public string Name;
    public string Bio;

    // Constructor chaining
    public Author(string title, int year, string name, string bio) 
            : base(title, year)
    {
        Name = name;
        Bio = bio;
    }

    // Overriding DisplayInfo
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}

class LibraryManagement
{
    static void Main()
    {
        Author book1 = new Author("I don't love you anymore", 2024, "Rithvik Singh", 
        "A book about moving on from past relationships by a writer of national bestsellers.");
        book1.DisplayInfo();
    }
}
