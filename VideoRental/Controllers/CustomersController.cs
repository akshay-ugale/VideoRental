using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {

            return View(cust1.Where(c=>c.Id==11));
        }

        public IActionResult Customer(int Id)
        {
            var customer = cust1.Where(c => c.Id == Id).FirstOrDefault();

            return View(customer);
        }

    }
}
