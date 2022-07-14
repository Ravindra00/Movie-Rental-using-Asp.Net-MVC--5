using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Rental
    {
        public int RentalId { get; set; }


        
        public Customer Customer { get; set; }


        
        public Movie Movie { get; set; }
        

        public DateTime RentedDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        
        public decimal Rate { get; set; }
    }
}