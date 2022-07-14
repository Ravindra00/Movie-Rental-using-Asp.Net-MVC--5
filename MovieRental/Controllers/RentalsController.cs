using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals

        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            
            var rentals = _context.Rentals.ToList();
            List<GetMovies> rentmodel = (from m in _context.Rentals
                                         let timeSpan = m.RentedDate - DateTime.Now
                                         select new GetMovies
                                   {
                                       CustomerName = m.Customer.Name,
                                       MovieName = m.Movie.Name,
                                       RentedDate = m.RentedDate,
                                       TotalDays = timeSpan.ToString(),
                                       Rate = m.Movie.Rate
                                   }).ToList();
            return View(rentmodel);
        }

        public ActionResult New()   
        {

            ViewBag.Movies = _context.Movie.ToList();
            ViewBag.Customers = _context.Customers.ToList();

            return View("RentalForm");

        }
        public ActionResult Save(RentalFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Customers = _context.Customers.ToList();
                ViewBag.Movies = _context.Movie.ToList();
                return View("RentalForm", model);
            }
            var customer = _context.Customers.Single(m => m.Id == model.CustomerId);
            var movie = _context.Movie.Single(m => m.Id == model.MovieId);

            Rental rental = new Rental()
            {
                Customer = customer,
                Movie = movie,
                RentedDate = DateTime.Now
            };

            //Rental rental = (from r in _context.Rentals 
            //                 select new Rental 
            //                 {
            //                    Customer = rental.Customer,
            //                     Movie = rental.Movie,
            //                    RentedDate = DateTime.Now
            //});
            _context.Rentals.Add(rental);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Report(List<GetMovies> movies)
        {
            //var dbvalue = _context.Rentals.ToList();
            // movies = (from m in _context.Rentals
            //                             select new GetMovies
            //                             {
            //                                 CustomerName = m.Customer.Name,
            //                                 MovieName = m.Movie.Name,
            //                                 RentedDate = m.RentedDate
            //                             }).ToList();
            ViewBag.Movies = _context.Movie.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Report(int  id)
        {
            ViewBag.Movies = _context.Movie.ToList();


            List<GetMovies> movies = new List<GetMovies>();
            using (_context)
            {
                var clientIdParameter = new SqlParameter("@id", id);

                movies = _context.Database
                   .SqlQuery<GetMovies>("GetMovies @id", clientIdParameter).ToList();
              
            }

            return View("Report",movies);
        }
       
    }
}