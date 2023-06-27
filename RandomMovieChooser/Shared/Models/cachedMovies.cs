using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovieChooser.Shared.Models
{
    public static class cachedMovies
    {
        public static List<MovieDetails> cachedMovieDetails = new List<MovieDetails>();
        public static bool gotCached = false;
    }
}
