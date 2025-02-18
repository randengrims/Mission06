using System.Diagnostics;
using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) 
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Application response)
        {
            _context.Applications.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
        
        // Get to know Joel Page
        public IActionResult KnowJoel() 
        {
            return View();
        }

        public IActionResult Waitlist()
        {
            var applications = _context.Applications
                .Where(x => x.Edited == false)
                .OrderBy(x => x.Title).ToList();

            return View(applications);
        }
    }
}