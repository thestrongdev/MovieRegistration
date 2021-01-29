using Microsoft.AspNetCore.Mvc;
using MovieRegistr.DALModels;
using MovieRegistr.Models;
using MovieRegistr.Models.MovieRegistration;
using MovieRegistr.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistr.Controllers
{
    public class MovieRegistrationController : Controller
    {
        private readonly IMovies _movieList;
        private readonly MovieContext _movieListContext;

        public MovieRegistrationController(IMovies movies, MovieContext movieContext)
        {
            _movieList = movies;
            _movieListContext = movieContext;
        }

        public IActionResult AddMovieForm()
        {
            return View();
        }

        public IActionResult AddMovieResult(AddMovieFormViewModel model)
        {
            var movie = new MovieDAL();
            movie.MovieId = model.ID;
            movie.Title = model.Title;
            movie.Genre = model.Genre;
            movie.Runtime = model.Runtime;

            _movieListContext.Movies.Add(movie);

            _movieListContext.SaveChanges();

           var viewModel = new AddMovieResultViewModel();
            var movies = _movieListContext.Movies.ToList();

            //need to do LINQ stuff here 

            return View(viewModel);
        }



    }
}
