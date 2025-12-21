using Microsoft.AspNetCore.Mvc;

namespace CoolRider_1.Controllers
{
    public class MapController : Controller
    {
        // Show Map page
        public IActionResult Index()
        {
            return View();
        }
    }
}
