using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoRental.Data;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

            
        }

        public IActionResult Customer(int Id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).Where(c=> c.Id == Id).SingleOrDefault();

            if (customers!=null)
            {
                return View(customers);
            }
            else
            {
                return Content("Not found");
            }
        }

    }
}
