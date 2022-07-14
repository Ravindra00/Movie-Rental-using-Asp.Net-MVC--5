using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.DAL
{
    public interface IMovieRepository
    {

        List<MovieFormViewModel> GetMovies();
        IEnumerable<Genre> GetGenres();
        MovieFormViewModel GetMovieById(int id);
        void AddMovie(MovieFormViewModel movie);
        void UpdateMovie(MovieFormViewModel model);
        void DeleteMovie(int id);
        void Save();
    }
}