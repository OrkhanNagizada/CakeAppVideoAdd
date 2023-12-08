using Microsoft.AspNetCore.Mvc;

namespace WebAppProjectAtHoliday.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
