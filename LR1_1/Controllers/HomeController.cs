using LR1_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR1_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 101);

            var company = new CompanyModel
            {
                RandomNumber = number,
                Number2 = 2,
                Name = "Makc",
                PhoneNumber = "+380 44 123 4567"
            };

            return View(company);
        }
    }
}
