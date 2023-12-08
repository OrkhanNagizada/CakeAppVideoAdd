namespace WebAppProjectAtHoliday.Models.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string AdedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
