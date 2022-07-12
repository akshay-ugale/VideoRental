using Microsoft.AspNetCore.Mvc;
using VideoRental.Data;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> cust1 = new List<Customer>(){
                new Customer(){Id = 1,Name = "Abilip" },
                new Customer(){Id = 2,Name = "Chilip" },
                new Customer(){Id = 3,Name = "Dilip" },

         };

        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);

            
        }

        public IActionResult Customer(int Id)
        {
            var customers = _context.Customers.SingleOrDefault();

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
