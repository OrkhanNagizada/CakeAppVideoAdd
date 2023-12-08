using WebAppProjectAtHoliday.Models.Entity;

namespace WebAppProjectAtHoliday.Models
{
    public class SocialMedia: BaseEntity
    {
        public string Name { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
