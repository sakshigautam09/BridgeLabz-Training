using System;
public class CinemaUtility : ICinemaService
{
    private Movie[] movies;
    private int count;
    private const int MAX_MOVIES = 100;

    public CinemaUtility()
    {
        movies = new Movie[MAX_MOVIES];
        count = 0;
    }

    // Add Movie
    public void AddMovie(string title, string time)
    {
        if (count >= MAX_MOVIES)
        {
            Console.WriteLine("Cannot add more movies. Maximum limit reached.");
            return;
        }

        if (IsValidTime(time))
        {
            movies[count] = new Movie(title, time);
            count++;
            Console.WriteLine("Movie added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid time. Please enter in HH:mm format (00:00 to 23:59).");
        }
    }

    // Search Movie
    public void SearchMovie(string keyword)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            string title = movies[i].GetTitle();

            if (IsKeywordPresent(title, keyword))
            {
                Console.WriteLine($"{movies[i].GetTitle()} - {movies[i].GetShowTime()}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No movie found with the given keyword.");
        }
    }
    private bool IsKeywordPresent(string text, string keyword)
    {
        if (keyword.Length > text.Length)
            return false;

        for (int i = 0; i <= text.Length - keyword.Length; i++)
        {
            bool match = true;

            for (int j = 0; j < keyword.Length; j++)
            {
                char c1 = char.ToLower(text[i + j]);
                char c2 = char.ToLower(keyword[j]);


                if (c1 != c2)
                {
                    match = false;
                    break;
                }
            }

            if (match)
                return true;
        }
        return false;
    }


    // Display All Movies
    public void DisplayAllMovies()
    {
        if (count == 0)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{movies[i].GetTitle()} - {movies[i].GetShowTime()}");
        }
    }

    private bool IsValidTime(string time)
    {
        if (!TimeSpan.TryParse(time, out TimeSpan parsedTime))
            return false;

        if (parsedTime.Hours > 23 || parsedTime.Minutes > 59)
            return false;

        return true;
    }
}
