using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMadness.Models
{
    public class MovieIndexViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }

        //list of Actors
        public List<ActorViewModel> ActorsMovies { get; set; }
    }
}