using Microsoft.AspNetCore.Mvc;

namespace LabMVC2.Controllers
{
    public class Pages : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Feature()
        {
            return View();
        }
        public IActionResult Quote()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
