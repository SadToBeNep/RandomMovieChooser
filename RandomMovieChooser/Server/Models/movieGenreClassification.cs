using RandomMovieChooser.Shared.Models;
using System.Diagnostics;

namespace RandomMovieChooser.Server.Models
{
    public static class movieGenreClassification
    {
        public static IDictionary<string, List<int>> movieGenres = new Dictionary<string, List<int>>
        {
            { "Action", new List<int>{ } },
            { "Adventure", new List<int>{ } },
            { "Animation", new List<int>{ } },
            { "Comedy", new List<int>{ } },
            { "Crime", new List<int>{ } },
            { "Documentary", new List<int>{ } },
            { "Drama", new List<int>{ } },
            { "Family", new List<int>{ } },
            { "Fantasy", new List<int>{ } },
            { "History", new List<int>{ } },
            { "Horror", new List<int>{ } },
            { "Music", new List<int>{ } },
            { "Mystery", new List<int>{ } },
            { "Romance", new List<int>{ } },
            { "Science Fiction", new List<int>{ } },
            { "TV Movie", new List<int>{ } },
            { "Thriller", new List<int>{ } },
            { "War", new List<int>{ } },
            { "Western", new List<int>{ } },
        };
        public static void clasificationOfMovies(List<MovieDetails> movies)
        {
            int counter = 0;
            translateGenreIDs translator = new translateGenreIDs();
            foreach(var movie in movies)
            {
                var genres = translator.translate(movie.Genres);
                foreach(var genre in genres)
                {
                    Debug.WriteLine("Current genre: " + genre);
                    if (!movieGenres[genre].Contains(counter))
                    {

                        Debug.WriteLine("Adding nth " + counter + " to the genre " + genre);
                        movieGenres[genre].Add(counter);
                    }
                }
                counter++;
            }
        }

    }

    
}
