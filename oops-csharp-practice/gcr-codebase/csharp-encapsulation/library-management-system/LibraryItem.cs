using System;
public abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;
    protected LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
    public abstract int GetLoanDuration();
}
