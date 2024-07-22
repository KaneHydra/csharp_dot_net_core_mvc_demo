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
        
        // ViewData 寫法1
        [ViewData]
        public string tel { get; set; }
        public string email { get; set; }

        public IActionResult Index()
        {
            // ViewData 寫法2
            ViewData["addr"] = "我家地址";
            tel = "我的電話";
            email= "我的email";
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
