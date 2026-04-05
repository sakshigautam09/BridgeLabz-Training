using System;
public class BookUtility : IBookService
{
    private Book[] books;          
    private int count;            
    private const int MAX_BOOKS = 100;

    public BookUtility()
    {
        books = new Book[MAX_BOOKS];
        count = 0;
    }

    // Add a new book
    public void AddBook(string title, string author)
    {
        if (count >= MAX_BOOKS)
        {
            Console.WriteLine("Cannot add more books. Maximum limit reached.");
            return;
        }

        books[count] = new Book(title, author);
        count++;
        Console.WriteLine("Book added successfully.");
    }

    public void SortBooksAlphabetically()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available to sort.");
            return;
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                string first = books[j].GetTitle().ToLower();
                string second = books[j + 1].GetTitle().ToLower();

                bool shouldSwap = false;
                int minLength = first.Length < second.Length ? first.Length : second.Length;

                for (int k = 0; k < minLength; k++)
                {
                    if (first[k] > second[k])
                    {
                        shouldSwap = true;
                        break;
                    }
                    else if (first[k] < second[k])
                    {
                        break;
                    }
                }

                // If characters are same but length differs
                if (!shouldSwap && first.Length > second.Length)
                {
                    shouldSwap = true;
                }

                if (shouldSwap)
                {
                    Book temp = books[j];
                    books[j] = books[j + 1];
                    books[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Books sorted alphabetically.");
    }


        // Search books by author
    public void SearchByAuthor(string author)
    {
        if (count == 0)
        {
            Console.WriteLine("No books available to search.");
            return;
        }

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            string storedAuthor = books[i].GetAuthor();

            if (IsSameAuthor(storedAuthor, author))
            {
                Console.WriteLine(books[i].GetBookInfo());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No books found by author: " + author);
        }
    }
    private bool IsSameAuthor(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            char c1 = char.ToLower(a[i]);
            char c2 = char.ToLower(b[i]);

            if (c1 != c2)
                return false;
        }
        return true;
    }


    // Display all books
    public void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books in the bookshelf.");
            return;
        }

        Console.WriteLine("\n My Bookshelf:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i].GetBookInfo());
        }
    }
}
