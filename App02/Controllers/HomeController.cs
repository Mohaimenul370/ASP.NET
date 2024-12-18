using App02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string usertext)
        {
            if(string.IsNullOrEmpty(usertext))
            {
                usertext = "sorry! no data is received.";
            }
            ViewBag.msg = usertext;
            return View();
        }
        public IActionResult Products(int id)
        {
            if (id==0) { id= 100; }
            ViewBag.msg = id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Play()
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