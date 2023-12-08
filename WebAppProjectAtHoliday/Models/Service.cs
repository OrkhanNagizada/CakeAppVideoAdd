using WebAppProjectAtHoliday.Models.Entity;

namespace WebAppProjectAtHoliday.Models
{
    public class Service: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReadMore { get; set; }
    }
}
