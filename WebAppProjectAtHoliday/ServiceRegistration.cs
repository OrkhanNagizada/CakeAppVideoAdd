using Microsoft.EntityFrameworkCore;
using WebAppProjectAtHoliday.DAL;

namespace WebAppProjectAtHoliday
{
    public static class ServiceRegistration
    {
        public static void Register (this IServiceCollection services,IConfiguration config)
        {

            services.AddControllersWithViews ();
            services.AddDbContext<AppDbContext>(op =>
            {
                op.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
