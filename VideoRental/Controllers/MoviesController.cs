using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoRental.Data;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Movies.Include(g=>g.Genre).ToList());
        }

        public IActionResult Random()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(g => g.Genre).Where(m => m.Id == Id).FirstOrDefault();
            return View(movie);
        }
    }
}
