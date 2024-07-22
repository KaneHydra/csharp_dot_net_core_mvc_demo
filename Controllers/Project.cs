using Microsoft.AspNetCore.Mvc;

namespace LabMVC2.Controllers
{
    public class Project : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
