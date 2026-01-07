using System;

public class DVD : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public DVD(int itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 3; 
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine("DVD reserved by " + borrower);
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
