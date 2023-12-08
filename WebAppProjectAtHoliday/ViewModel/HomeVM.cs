using WebAppProjectAtHoliday.Models;

namespace WebAppProjectAtHoliday.ViewModel
{
    public class HomeVM
    {
        public Hero Hero { get; set; }
        public About About { get; set; }
        public Dictionary<string, string> Facts { get; set; }
        public  List<Service> services { get; set; }
        public ServiceDiscount ServiceDiscount { get; set; }
        public List<Team> teams { get; set; }
        public List<SocialMedia> socialMedias{ get; set; }
    }
}
