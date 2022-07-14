using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public  Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public DateTime? ReleasedDate { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public decimal Rate { get; set; }
    }
}