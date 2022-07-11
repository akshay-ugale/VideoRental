using Microsoft.AspNetCore.Mvc;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name ="Shrek!"};
            return View(movie);
        }
    }
}
