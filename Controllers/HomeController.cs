using _213002_Assignment05.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _213002_Assignment05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.Title = "This is index2.";
            return View();
        }

        [HttpGet]
        public IActionResult ValidateAge()
        {
            ViewBag.Title = "Validate age for voting";
            Person person = new Person();
            return View(person);
        }

        [HttpPost]
        public IActionResult ValidateAge(Person person)
        { 
            if (person.Age >= 18)
            {
                ViewBag.Message = "You are eligible to vote.";
            }
            else
            {
                ViewBag.Message = "Sorry! You are not old enough to vote.";
            }
            return View();
        }

        public IActionResult Activity4()
        {
            return View();
        }

        public IActionResult Activity5()
        {
            return View();
        }

        public IActionResult Activity6()
        {
            return View();
        }
    }
}
