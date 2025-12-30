using System;
class LibraryManagementSystem
{
    static string[] titles = { "C# Basics", "Java Programming", "Data Structures", "C# OOPS", "C++", "Python" };
    static string[] authors = { "Anders Hejlsberg", "James Gosling", "Mark", "Anders Hejlsberg", "Bjarne Stroustrup", "Guido van Rossum" };
    static Boolean[] isAvailable = { true, true, false, true, false, true };

    static int BookCount()
    {
        return titles.Length;
    }   
    static string ADMIN_PASSWORD = "admin123";

    public static void Main()
    {
        int chooseOption = 0;

        while (chooseOption != 3)
        {
            Console.WriteLine("\n===== Library Management System =====");
            Console.WriteLine("1. Admin (Librarian)");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            chooseOption = Convert.ToInt32(Console.ReadLine());

            switch (chooseOption)
            {
                case 1:
                    AdminLogin(); // checks passcode before showing admin menu
                    break;

                case 2:
                    UserMenu(); // shows user menu
                    break;

                case 3:
                    Console.WriteLine("Thank you for using LMS!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Admin Authentication 
    private static void AdminLogin()
    {
        Console.Write("Enter Admin Passcode: ");
        string pass = Console.ReadLine();

        if (pass == ADMIN_PASSWORD)
        {
            AdminMenu();
        }
        else
        {
            Console.WriteLine("Access Denied! Wrong Passcode.");
        }
    }

    // Admin Menu 
    private static void AdminMenu()
    {
        int chooseOption = 0;
        while (chooseOption != 6)
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Add Book");
            Console.WriteLine("4. Remove Book");
            Console.WriteLine("5. Update Book");
            Console.WriteLine("6. Logout");
            Console.Write("Enter choice: ");
            chooseOption = Convert.ToInt32(Console.ReadLine());

            switch (chooseOption)
            {
                case 1:
                    DisplayBooks();
                    break;
                case 2:
                    Console.Write("Enter title: ");
                    SearchBook(Console.ReadLine());
                    break;
                case 3:
                    AddBook();
                    break;
                case 4:
                    RemoveBook();
                    break;
                case 5:
                    UpdateBook();
                    break;
                case 6:
                    Console.WriteLine("Admin logged out.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // User Menu 
    private static void UserMenu()
    {
        int chooseOption = 0;
        while (chooseOption != 5)
        {
            Console.WriteLine("\n--- User Menu ---");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            chooseOption = Convert.ToInt32(Console.ReadLine());

            switch (chooseOption)
            {
                case 1:
                    DisplayBooks();
                    break;
                case 2:
                    Console.Write("Enter title: ");
                    SearchBook(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Enter title: ");
                    CheckoutBook(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Enter title: ");
                    ReturnBook(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("User exited.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // all the functions
    private static void DisplayBooks()
    {
        Console.WriteLine("\nBooks List:");
        for (int i = 0; i < BookCount(); i++)
        {
            string status = isAvailable[i] ? "Available" : "Checked Out";
            Console.WriteLine($"{i + 1}. {titles[i]} by {authors[i]} - {status}");
        }
    }

    private static void SearchBook(string text)
    {
        bool found = false;
        for (int i = 0; i < BookCount(); i++)
        {
            if (titles[i].ToLower().Contains(text.ToLower()))
            {
                Console.WriteLine($"{titles[i]} by {authors[i]}");
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("Book not found.");
    }

    private static void AddBook()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();

        Array.Resize(ref titles, bookCount + 1);
        Array.Resize(ref authors, bookCount + 1);
        Array.Resize(ref isAvailable, bookCount + 1);

        titles[bookCount] = title;
        authors[bookCount] = author;
        isAvailable[bookCount] = true;

        bookCount++;
        Console.WriteLine("Book added successfully.");
    }

    private static void RemoveBook()
    {
        Console.Write("Enter the book title to remove: ");
        string title = Console.ReadLine();
        int index = -1;

        for (int i = 0; i < BookCount(); i++)
        {
            if (titles[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                index = i;
                break;
            }
        }
        if (index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        for (int i = index; i < BookCount() - 1; i++)
        {
            titles[i] = titles[i + 1];
            authors[i] = authors[i + 1];
            isAvailable[i] = isAvailable[i + 1];
        }

        // Resize arrays
        Array.Resize(ref titles, BookCount() - 1);
        Array.Resize(ref authors, BookCount() - 1);
        Array.Resize(ref isAvailable, BookCount() - 1);

        Console.WriteLine("Book removed successfully.");
    }

    private static void UpdateBook()
    {
        Console.Write("Enter the book title to update: ");
        string oldTitle = Console.ReadLine();
        int index = -1;

        for (int i = 0; i < BookCount(); i++)
        {
            if (titles[i].Equals(oldTitle, StringComparison.OrdinalIgnoreCase))
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        Console.Write("Enter new title: ");
        titles[index] = Console.ReadLine();
        Console.Write("Enter new author: ");
        authors[index] = Console.ReadLine();

        Console.WriteLine("Book updated successfully.");
    }

    private static void CheckoutBook(string title)
    {
        for (int i = 0; i < BookCount(); i++)
        {
            if (titles[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (isAvailable[i])
                {
                    isAvailable[i] = false;
                    Console.WriteLine("Book checked out.");
                }
                else
                {
                    Console.WriteLine("Book already checked out.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    private static void ReturnBook(string title)
    {
        for (int i = 0; i < BookCount(); i++)
        {
            if (titles[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                isAvailable[i] = true;
                Console.WriteLine("Book returned.");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }
}
