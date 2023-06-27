using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using RandomMovieChooser.Server.Services;
using RandomMovieChooser.Shared.Models;
using System.Diagnostics;

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
            return "x";
        }
    }
}
