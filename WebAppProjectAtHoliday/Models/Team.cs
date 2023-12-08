using WebAppProjectAtHoliday.Models.Entity;

namespace WebAppProjectAtHoliday.Models
{
    public class Team: BaseEntity
    {
        public string Title { get; set; }
        public string Masters { get; set; }
        public string ImgUrl { get; set; }
        public string FullName { get; set; }
        public string Desc { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
