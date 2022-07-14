using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class GetMovies
    {
        public string name { get; set; }

        public string CustomerName { get; set; }
        public string MovieName { get; set; }
        public DateTime RentedDate { get; set; }

        public string TotalDays { get; set; }

        public decimal Rate { get; set; }
        public int TotalAmount { get; set; }


    }
}