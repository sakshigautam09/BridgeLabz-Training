using System;
// Node of Doubly Linked List
public class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;

    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}
public class MovieDoublyLinkedList
{
    private MovieNode head;
    private MovieNode tail;

    public MovieDoublyLinkedList()
    {
        head = null;
        tail = null;
    }

    // Add at beginning
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
    }

    // Add at end
    public void AddAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newNode = new MovieNode(title, director, year, rating);

        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
    }

    // Add at specific position (1-based)
    public void AddAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position <= 1 || head == null)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        int count = 1;

        while (temp.Next != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp.Next == null)
        {
            AddAtEnd(title, director, year, rating);
        }
        else
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = temp.Next;
            newNode.Prev = temp;
            temp.Next.Prev = newNode;
            temp.Next = newNode;
        }
    }

    // Remove by Movie Title
    public void RemoveByTitle(string title)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (temp == head)
                {
                    head = head.Next;
                    if (head != null) head.Prev = null;
                }
                else if (temp == tail)
                {
                    tail = tail.Prev;
                    tail.Next = null;
                }
                else
                {
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }

                Console.WriteLine("Movie removed successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    // Search by Director
    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found for this director.");
    }

    // Search by Rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                DisplayMovie(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating.");
    }

    // Update Rating by Title
    public void UpdateRating(string title, double newRating)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Movie not found.");
    }

    // Display forward
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movie records available.");
            return;
        }

        Console.WriteLine("\n--- Movies (Forward) ---");
        MovieNode temp = head;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movie records available.");
            return;
        }

        Console.WriteLine("\n--- Movies (Reverse) ---");
        MovieNode temp = tail;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.Prev;
        }
    }

    private void DisplayMovie(MovieNode movie)
    {
        Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}");
    }
}
class MovieManagementSystem
{
    static void Main()
    {
        MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

        movies.AddAtEnd("Inception", "Christopher Nolan", 2010, 9.0);
        movies.AddAtBeginning("Titanic", "James Cameron", 1997, 8.5);
        movies.AddAtPosition("Interstellar", "Christopher Nolan", 2014, 8.8, 2);

        movies.DisplayForward();
        movies.DisplayReverse();

        movies.SearchByDirector("Christopher Nolan");
        movies.SearchByRating(8.5);

        movies.UpdateRating("Titanic", 9.1);
        movies.RemoveByTitle("Inception");

        movies.DisplayForward();
    }
}