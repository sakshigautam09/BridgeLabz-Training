using System;
public class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public Book(int itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 14; 
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine("Book reserved by " + borrower);
        }
    }
    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
