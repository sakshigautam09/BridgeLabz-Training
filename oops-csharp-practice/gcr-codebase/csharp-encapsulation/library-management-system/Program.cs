using System;
class Program
{
    static void Main()
    {
        LibraryItem[] items = new LibraryItem[3];

        Book book = new Book(101, "The subtle art of not giving a f*ck", "Mark Manson");
        Magazine magazine = new Magazine(102, "Tech Monthly", "Hindu Editorial");
        DVD dvd = new DVD(103, "Inception", "Christopher Nolan");

        items[0] = book;
        items[1] = magazine;
        items[2] = dvd;

        Console.WriteLine("=== Library Management System ===");

        for (int i = 0; i < items.Length; i++)
        {
            items[i].GetItemDetails();
            Console.WriteLine("Loan Duration (days): " + items[i].GetLoanDuration());

            IReservable reservable = items[i] as IReservable;
            if (reservable != null)
            {
                Console.WriteLine("Available: " + reservable.CheckAvailability());
                reservable.ReserveItem("User" + (i + 1));
                Console.WriteLine("Available After Reservation: " + reservable.CheckAvailability());
            }
        }
    }
}
