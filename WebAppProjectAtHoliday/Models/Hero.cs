using WebAppProjectAtHoliday.Models.Entity;

namespace WebAppProjectAtHoliday.Models
{
    public class Hero:BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Desc { get; set; }
        public string Video { get; set; }
        public string ReadMore { get; set; }
        public string ImgUrl { get; set; }
    }
}
