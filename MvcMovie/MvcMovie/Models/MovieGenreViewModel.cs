using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        // list of all movies
        public List<Movies> movies;

        // list of genres 
        public SelectList genres;

        // string containing the selected genre
        public string movieGenre { get; set; }
    }
}
