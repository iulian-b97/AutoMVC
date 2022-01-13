namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class AnnouncementDto 
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; } 
        public string SellerId { get; set; }
    }
}
