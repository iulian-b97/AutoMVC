using System.Collections.Generic;


namespace AnnouncementManagement.Domain.Entities
{
    public class Seller
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
