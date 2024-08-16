using Microsoft.AspNetCore.Mvc;

namespace Travel_Trip_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
