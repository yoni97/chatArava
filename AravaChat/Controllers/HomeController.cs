using AravaChat.Models;
using Microsoft.AspNetCore.Mvc;
using AravaChat.DAL;
using System.Diagnostics;

namespace AravaChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult AllUsers()
        {
            List<User> users = Data.Get.Users.ToList(); 
            return View(users);
        }

        public IActionResult Create() { return View(); }
        

















        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
