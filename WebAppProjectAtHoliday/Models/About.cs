using WebAppProjectAtHoliday.Models.Entity;

namespace WebAppProjectAtHoliday.Models
{
    public class About: BaseEntity
    {
        public string Title { get; set; }
        public string BigTitle { get; set; }
        public string DescTitle { get; set; }
        public string Desc { get ; set; }
        public string Healthy { get; set; }
        public string Award { get; set; }
        public string ImgUrl { get; set; } 
    }
}
