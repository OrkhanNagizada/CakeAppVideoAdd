using Microsoft.AspNetCore.Mvc;

namespace WebAppProjectAtHoliday.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
