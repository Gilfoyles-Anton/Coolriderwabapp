using Microsoft.AspNetCore.Mvc;

namespace CoolRider_1.Controllers
{
    public class RouteController : Controller
    {
        // GET: /Route/Index
        public IActionResult Index()
        {
            // Data can be passed to the view
            ViewData["Title"] = "Route";
            return View();
        }
    }
}
