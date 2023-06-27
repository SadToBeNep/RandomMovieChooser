using RestSharp;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Cryptography.Xml;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using RandomMovieChooser.Shared.Models;
using RandomMovieChooser.Server.Models;

namespace RandomMovieChooser.Server.Services
{
    public class FetchMovies
    {
        public FetchMovies() 
        {
           
        }

        public List<MovieDetails> getMoviesAsList()
        {
            //var client = new RestClient("https://api.themoviedb.org/3/discover/movie?include_adult=true&include_video=false&language=en-US&release_date.gte=2010&release_date.lte=2099&sort_by=popularity.desc");
            //var request = new RestRequest();
            //request.AddHeader("accept", "application/json");
            //request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI5YzkzMzE3NmJiNjE4MGE4Yzk3YmJlYmEzZTBkZjU4NCIsInN1YiI6IjY0OTMzMmE4N2FlY2M2MDE0ZWZlNzU5YSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.1s3f6pTGegguVJdJsLVrOTAElln-IimA1x31vvHwi6M");
            
            
            List<MovieDetails> movieDetails = new List<MovieDetails>();
            for (int x = 1; x <= 25; x++)
            {
                string baseURL = "https://api.themoviedb.org/3/discover/movie?include_adult=true&include_video=false&language=en-US&release_date.gte=2010&release_date.lte=2099&sort_by=popularity.desc&" + "page=" + x;
                var client = new RestClient(baseURL);
                var request = new RestRequest();
                request.AddHeader("accept", "application/json");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI5YzkzMzE3NmJiNjE4MGE4Yzk3YmJlYmEzZTBkZjU4NCIsInN1YiI6IjY0OTMzMmE4N2FlY2M2MDE0ZWZlNzU5YSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.1s3f6pTGegguVJdJsLVrOTAElln-IimA1x31vvHwi6M");
                RestResponse response = client.Execute(request);
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response.Content);
                foreach (var res in myDeserializedClass.results)
                {
                    movieDetails.Add(new MovieDetails
                    {
                        Title = res.original_title,
                        Description = res.overview,
                        ReleaseDate = res.release_date,
                        Genres = res.genre_ids,
                        pictureURL = res.backdrop_path
                    });
                }
                client.Dispose();
                Thread.Sleep(100);
            }
            Debug.WriteLine(movieDetails.Count);
            cachedMovies.cachedMovieDetails = movieDetails;
            cachedMovies.gotCached = true;
            Debug.WriteLine("Clasification 1");
            classification(movieDetails);
            Debug.WriteLine("Clasification 2");

            return movieDetails;
        }

        public void classification(List <MovieDetails> movies)
        {
            Debug.WriteLine("Clasification 3");
            movieGenreClassification.clasificationOfMovies(movies);
            Debug.WriteLine("Clasification 4");
        }
    }
}
