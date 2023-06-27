using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RandomMovieChooser.Server.Services;
using RandomMovieChooser.Shared.Models;
using System.Diagnostics;
using RandomMovieChooser.Server.Models;

namespace RandomMovieChooser.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public string getMovies()
        {
            List<MovieDetails> TopMovies = new List<MovieDetails>();
            if (cachedMovies.gotCached == false)
            {
                FetchMovies movies = new FetchMovies();
                TopMovies = movies.getMoviesAsList();
            }
            else
            {
                TopMovies = cachedMovies.cachedMovieDetails;
            }

            Random rand = new Random();
            int randomFromList = rand.Next(TopMovies.Count);
            translateGenreIDs translator = new translateGenreIDs();

            List<string> translatedGens = translator.translate(TopMovies[randomFromList].Genres);

            MovieDetails returnMovieDetails = new MovieDetails
            {
                Title = TopMovies[randomFromList].Title,
                Description = TopMovies[randomFromList].Description,
                ReleaseDate = TopMovies[randomFromList].ReleaseDate,
                Genres = TopMovies[randomFromList].Genres,
                translatedGenres = translatedGens,
                pictureURL = TopMovies[randomFromList].pictureURL
            
            };

            string json = JsonSerializer.Serialize(returnMovieDetails);
            return json;

        }

        [HttpGet]
        [Route("getMovieByCategory")]
        public string getMoviesByCategory(string includeMovies)
        {
            List<string> translatedGens = new List<string>();
            List<MovieDetails> TopMovies = new List<MovieDetails>();
            if (cachedMovies.gotCached == false)
            {
                FetchMovies fetchMovies= new FetchMovies();
                TopMovies = fetchMovies.getMoviesAsList();
            }
            else
            {
                TopMovies = cachedMovies.cachedMovieDetails;
            }
            List<MovieDetails> movies = new List<MovieDetails>();
            string[] splittedQuery = includeMovies.Split(',');
            foreach(string query in splittedQuery)
            {
                if (query == "") { break; }
                List<int> currentGenre = movieGenreClassification.movieGenres[query];
                foreach(int movie in currentGenre)
                {
                    movies.Add(TopMovies[movie]);
                }
            }

            Random rand = new Random();
            int randomFromList = rand.Next(movies.Count);
            translateGenreIDs translator = new translateGenreIDs();
            try
            {
                translatedGens = translator.translate(movies[randomFromList].Genres);
            }catch(Exception e)
            {
                MovieDetails returnMovieDetail = new MovieDetails
                {
                    Title = e.Message,
                    Description = e.Message,
                    ReleaseDate = e.Message,
                    Genres = new List<int> { e.Message.Length },
                    translatedGenres = new List<string> { e.Message },
                    pictureURL = e.Message,

                };
                string jsonError = JsonSerializer.Serialize(returnMovieDetail);
                return jsonError;


            }
            MovieDetails returnMovieDetails = new MovieDetails
            {
                Title = movies[randomFromList].Title,
                Description = movies[randomFromList].Description,
                ReleaseDate = movies[randomFromList].ReleaseDate,
                Genres = movies[randomFromList].Genres,
                translatedGenres = translatedGens,
                pictureURL = movies[randomFromList].pictureURL

            };

            string json = JsonSerializer.Serialize(returnMovieDetails);
            return json;

        }
    }
}
