using LabMVC2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabMVC2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        // ViewData �g�k1
        [ViewData]
        public string tel { get; set; }
        public string email { get; set; }

        public IActionResult Index()
        {
            // ViewData �g�k2
            ViewData["addr"] = "�ڮa�a�}";
            tel = "�ڪ��q��";
            email= "�ڪ�email";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
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
