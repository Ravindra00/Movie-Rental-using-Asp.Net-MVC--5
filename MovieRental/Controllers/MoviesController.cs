using MovieRental.DAL;
using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {


        private IMovieRepository movieRepository;

        public MoviesController()
        {
            this.movieRepository = new MovieRepository(new ApplicationDbContext());
        }

        public MoviesController(IMovieRepository movieRepository)
        {

            this.movieRepository = movieRepository;
        }
       public ActionResult Index()
        {
            var movie = movieRepository.GetMovies();
            return View(movie);
        }
        public ActionResult Add()
        {
            ViewBag.Genre = movieRepository.GetGenres();
            return View("MovieForm");
        }

        [HttpPost]
        public ActionResult Save(MovieFormViewModel movie)
           {
            
            
            if (!ModelState.IsValid)
            {
                ViewBag.Genre = movieRepository.GetGenres();
                return View("MovieForm", movie);
            }
            
            if(movie.Id == 0)
            {
               movieRepository.AddMovie(movie);
            }
            else
            {
                ViewBag.Genre = movieRepository.GetGenres();
                movieRepository.UpdateMovie(movie);
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                movieRepository.DeleteMovie(id);
                movieRepository.Save();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
                {

            var movies = movieRepository.GetMovieById(id);
            if (movies == null)
                return HttpNotFound();

            else
            {
                ViewBag.Genre = movieRepository.GetGenres();
                return View("MovieForm", movies);
            }
        }
    }
}