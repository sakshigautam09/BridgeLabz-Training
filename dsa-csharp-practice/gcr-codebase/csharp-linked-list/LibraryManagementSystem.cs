using System;

// Doubly Linked List Node
class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(int id, string title, string author, string genre, bool available)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = available;
        Prev = null;
        Next = null;
    }
}

// Doubly Linked List
class Library
{
    private BookNode head;
    private BookNode tail;

    // Add book at end (easy & common)
    public void AddBook(int id, string title, string author, string genre, bool available)
    {
        BookNode newBook = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = newBook;
            return;
        }

        tail.Next = newBook;
        newBook.Prev = tail;
        tail = newBook;
    }

    // Remove book by ID
    public void RemoveBook(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp == head)
                    head = temp.Next;

                if (temp == tail)
                    tail = temp.Prev;

                if (temp.Prev != null)
                    temp.Prev.Next = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;

                Console.WriteLine("Book removed.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    // Search by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found.");
    }

    // Search by Author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("Book not found.");
    }

    // Update availability
    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.IsAvailable = status;
                Console.WriteLine("Availability updated.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found.");
    }

    // Display forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\n--- Books (Forward) ---");
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\n--- Books (Reverse) ---");
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine($"Total books in library: {count}");
    }

    private void DisplayBook(BookNode book)
    {
        Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
    }
}

// Main
class LibraryManagementSystem
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(1, "C# Basics", "John", "Programming", true);
        library.AddBook(2, "Data Structures", "Alice", "CS", true);
        library.AddBook(3, "Operating Systems", "Bob", "CS", false);

        library.DisplayForward();
        library.DisplayReverse();

        library.SearchByAuthor("Alice");
        library.UpdateAvailability(3, true);

        library.RemoveBook(2);
        library.DisplayForward();

        library.CountBooks();
    }
}
