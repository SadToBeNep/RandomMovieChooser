using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovieChooser.Shared.Models
{
    public class MovieDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public List<int> Genres { get; set; }
        public string pictureURL { get; set; }

        public List<string>? translatedGenres { get; set; }

        public void display()
        {
            Console.WriteLine(
                "Title: " + Title + "\nRelease Year" + ReleaseDate + "\nDescription" + Description);
        }
    }

}
