using MovieMadness.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieMadness.Models
{
    //ViewModel for AddActor
    public class AddActorViewModel
    {
        [Display(Name = "Actors")]
        public int SelectedActorId { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
        [Display(Name = "Movies")]
        public int SelectedMovieId { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}