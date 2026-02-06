// using System;

// class TicketService
// {
//     private Movie[] movies;      
//     private int movieCount;     
//     private int maxMovies;     
//     public TicketService(int maxMovies) 
//     {
//         this.maxMovies = maxMovies;
//         movies = new Movie[maxMovies];
//         movieCount = 0;
//     }

//     public void AddMovie(Movie movie)
//     {
//         if (movieCount >= maxMovies)
//         {
//             Console.WriteLine("Cannot add more movies, limit reached!");
//             return;
//         }
//         movies[movieCount] = movie;
//         movieCount++;
//         Console.WriteLine("Movie added successfully!");
//     }

//     public void ShowMoviesWithIndex()
//     {
//         if (movieCount == 0)
//         {
//             Console.WriteLine("No movies available!");
//             return;
//         }
//         Console.WriteLine("--- Movie List ---");
//         for (int i = 0; i < movieCount; i++)
//         {
//             movies[i].ShowInfo(i + 1);
//         }
//     }
//     public bool BookTicketsByIndex(int index, int count)
//     {
//         if (index <= 0 || index > movieCount)
//             return false;

//         return movies[index - 1].BookTickets(count); 
//     }
// }



