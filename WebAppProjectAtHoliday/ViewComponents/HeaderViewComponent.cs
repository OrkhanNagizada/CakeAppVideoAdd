using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppProjectAtHoliday.DAL;
using WebAppProjectAtHoliday.ViewModel;

namespace WebAppProjectAtHoliday.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HeaderVM headerVM = new HeaderVM();
           headerVM.Settings=_context.topbars.AsNoTracking().ToDictionary(s=>s.Key, s=>s.Value);
            

            return View(headerVM);
        }
    }
    
}
