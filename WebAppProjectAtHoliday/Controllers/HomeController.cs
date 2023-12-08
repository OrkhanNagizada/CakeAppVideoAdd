using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppProjectAtHoliday.DAL;
using WebAppProjectAtHoliday.ViewModel;

namespace WebAppProjectAtHoliday.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           HomeVM vm = new HomeVM();
            vm.Hero = _context.heroes.FirstOrDefault();
            vm.About = _context.abouts.FirstOrDefault();
            vm.Facts = _context.facts.AsNoTracking().ToDictionary(f => f.Key, f => f.Value);
            vm.services=_context.services.ToList();
            vm.ServiceDiscount=_context.serviceDiscount.FirstOrDefault();
            vm.teams=_context.teams
                .Include(s=>s.SocialMedias)
                .ToList();
            vm.socialMedias=_context.socialMedia.ToList();

            return View(vm);
        }
    }
}
