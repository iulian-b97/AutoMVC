using AnnouncementManagement.Domain.Entities.Vehicle;

namespace AnnouncementManagement.Domain.Entities
{
    public class Announcement
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public virtual string SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Car Car { get; set; }
        public virtual Motorcycle Motorcycle { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual Van Van { get; set; }
        public virtual Trailer Trailer { get; set; }
    }
}
