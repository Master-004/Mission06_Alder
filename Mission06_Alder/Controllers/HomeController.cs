using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Alder.Models;

namespace Mission06_Alder.Controllers
{
    public class HomeController : Controller
    {
        private MovieRatingsContext _context; // Private variable to be passed on

        public HomeController(MovieRatingsContext MovieData) //constructor
        {
            _context = MovieData;
        }

        public IActionResult Index() // Index page
        {
            return View();
        }

        public IActionResult About() // About page
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies() // Add movie page - loads form
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie response) // Add movie to the database and return/load the confirmation page
        {
            _context.Movies.Add(response); //add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }



        // IGNORE CODE BELOW--
        // I do not know what this code does, but it was not working if I deleted it earlier... but commenting it out seemed to work.

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
