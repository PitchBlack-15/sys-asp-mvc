using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspmvc.Models;
using aspmvc.ViewModels;

namespace aspmvc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View(GetMovies());
        }

        public ActionResult MovieDetails(int id)
        {
            var detail = GetMovies().SingleOrDefault(d => d.ID == id);

            if (detail == null)
                return HttpNotFound();

            return View(detail);
        }

        private IEnumerable<Movie> GetMovies()
        {
           return new List<Movie>() {
              //  new Movie{ID = 1,  Name = "Shrek!" },
              //  new Movie{ID = 2, Name = "Forrest Gump" }

           };
        }


        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            // 
            // return Content("Hello World");
            //return HttpNotFound();
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page =1 , sortBy = "name"});
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
   

        [Route("movies/released/{year:regex(2015|2016)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleasedDate(int? year, int? month)
        {
            return Content($"year={year} month={month}");
        }


       


    }
}