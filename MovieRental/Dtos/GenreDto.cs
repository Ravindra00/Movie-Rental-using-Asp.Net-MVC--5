using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Dtos
{
    public class GenreDto
    {
        [Key]
        public byte GenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}