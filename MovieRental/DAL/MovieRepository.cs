using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieRental.Models;

namespace MovieRental.DAL
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void AddMovie(MovieFormViewModel movie)
        {
            Movie movies = new Movie();

            
            movies.Name = movie.Name;
            movies.GenreId = movie.GenreId;
            movies.ReleasedDate = movie.ReleasedDate;
            movies.Rate = movie.Rate;
            //movies.Rate = movie.Rate;
            _context.Movie.Add(movies);
            Save();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = _context.Movie.Find(id);
            _context.Movie.Remove(movie);
            Save();
        }

        public MovieFormViewModel GetMovieById(int id)
        {

            var movie = _context.Movie.FirstOrDefault(m => m.Id == id);
            MovieFormViewModel movieview = new MovieFormViewModel()
            {
                Id = movie.Id,
                Name = movie.Name,
                Genre = movie.Genre,
                ReleasedDate = movie.ReleasedDate,
                GenreId = movie.GenreId

            };

            return movieview;
        }
        public IEnumerable<Genre> GetGenres()
        {
            return _context.Genre.ToList();
        }
        public List<MovieFormViewModel> GetMovies()
        {
            List<MovieFormViewModel> newlist = (from m in _context.Movie
                                                select new MovieFormViewModel
                                                {
                                                    Id = m.Id,
                                                    Name = m.Name,
                                                    GenreId = m.GenreId,
                                                    ReleasedDate = m.ReleasedDate,
                                                    Genre = m.Genre,
                                                    Rate = m.Rate

                                                }).ToList();
            return newlist;
            
   
        }
        public void UpdateMovie(MovieFormViewModel model)
        {
            //var data = _context.Movie.Where(x => x.Id == model.Id).FirstOrDefault();
            var data = _context.Movie.Find(model.Id);
            if (data != null)
            {
                data.Name = model.Name;
                data.ReleasedDate = model.ReleasedDate;
                data.GenreId = model.GenreId;
            }
            _context.SaveChanges();
            //var movieindb = GetMovieById(movie.Id);
            //movieindb.Name = movie.Name;
            //movieindb.ReleasedDate = movie.ReleasedDate;
            //movieindb.GenreId = movie.GenreId;
            //movieindb.Genre = movie.genre;

            //Save();
            //    //context.Entry(movie).State = EntityState.Modified;
        }

        
    }

        
}
