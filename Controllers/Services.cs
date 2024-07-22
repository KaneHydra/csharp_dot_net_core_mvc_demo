using Microsoft.AspNetCore.Mvc;

namespace LabMVC2.Controllers
{
    public class Services : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
