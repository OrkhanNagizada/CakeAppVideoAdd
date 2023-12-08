using Microsoft.EntityFrameworkCore;
using WebAppProjectAtHoliday.Models;

namespace WebAppProjectAtHoliday.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Topbar> topbars { get; set; }
        public DbSet<Hero> heroes { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Facts> facts { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ServiceDiscount> serviceDiscount { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<SocialMedia> socialMedia { get; set; }
    }
}
