using System.Diagnostics;
using DateMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private DatingApplicationContext _context;
        public HomeController(DatingApplicationContext temp) 
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DatingApplication(Application response)
        {
            _context.Applications.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
