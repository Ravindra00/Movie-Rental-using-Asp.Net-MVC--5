using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRental.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public virtual Genre Genre { get; set; }
        [ForeignKey("Genre")]
        public byte GenreId { get; set; }

        public DateTime? ReleasedDate { get; set; }

    }
}