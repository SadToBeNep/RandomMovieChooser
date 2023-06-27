using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovieChooser.Shared.Models
{
    public class translateGenreIDs
    {
        List<string> translated = new List<string>();
        public List<string> translate(List<int> ids)
        {
           translated = new List<string>();
            foreach (int id in ids)
            {
                switch (id)
                {
                    case 28:
                        translated.Add("Action");
                        break;
                    case 12:
                        translated.Add("Adventure");
                        break;
                    case 16:
                        translated.Add("Animation");
                        break;
                    case 35:
                        translated.Add("Comedy");
                        break;
                    case 80:
                        translated.Add("Crime");
                        break;
                    case 99:
                        translated.Add("Documentary");
                        break;
                    case 18:
                        translated.Add("Drama");
                        break;
                    case 10751:
                        translated.Add("Family");
                        break;
                    case 14:
                        translated.Add("Fantasy");
                        break;
                    case 36:
                        translated.Add("History");
                        break;
                    case 27:
                        translated.Add("Horror");
                        break;
                    case 10402:
                        translated.Add("Music");
                        break;
                    case 9648:
                        translated.Add("Mystery");
                        break;
                    case 10749:
                        translated.Add("Romance");
                        break;
                    case 878:
                        translated.Add("Science Fiction");
                        break;
                    case 10770:
                        translated.Add("TV Movie");
                        break;
                    case 53:
                        translated.Add("Thriller");
                        break;
                    case 10752:
                        translated.Add("War");
                        break;
                    default:
                        break;
                }
            }

            return translated;
        }
        public string returnFormated()
        {
            string temp = "Genres: ";
            foreach (string gen in translated)
            {
                temp += gen + ",";
            }
            return temp;
        }
    }

}
