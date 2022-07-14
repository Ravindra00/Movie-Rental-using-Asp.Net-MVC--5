using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class HomeController : Controller

    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index(MovieFormViewModel model)
        {
            var movies = _context.Movie.ToList();
            return View(movies);
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoginForm()
        {
            return View();
        }
    }
}