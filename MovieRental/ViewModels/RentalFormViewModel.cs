using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRental.ViewModels
{
    public class RentalFormViewModel
    {
        public int RentalId { get; set; }


        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public DateTime RentedDate { get; set; }

        IEnumerable<Movie> Movies { get; set; }

        IEnumerable<Customer> Customers { get; set; }

        public decimal Rate { get; set; }
       

    }
    
}