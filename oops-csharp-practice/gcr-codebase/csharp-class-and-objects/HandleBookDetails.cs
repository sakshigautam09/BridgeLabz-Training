using System;
class Book
{
    public string Title;
    public string Author;
    public double Price;

    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Book Author: " + Author);
        Console.WriteLine("Book Price: " + Price);
    }

}
class HandleBookDetails
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.Title = "I don't love you anymore";
        book.Author = "Rithvik Singh";
        book.Price = 100;

        book.DisplayDetails();
    }
}