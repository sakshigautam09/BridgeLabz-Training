using System;

public class Magazine : LibraryItem, IReservable
{
    private bool isAvailable = true;
    private string borrowerName;

    public Magazine(int itemId, string title, string author)
        : base(itemId, title, author)
    {
    }

    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            borrowerName = borrower;
            isAvailable = false;
            Console.WriteLine("Magazine reserved by " + borrower);
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
