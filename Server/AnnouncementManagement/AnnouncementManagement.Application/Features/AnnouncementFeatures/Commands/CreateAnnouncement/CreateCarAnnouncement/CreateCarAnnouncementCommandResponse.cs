namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommandResponse
    {
        public AnnouncementDto Announcement { get; set; }
        public CarDto Car { get; set; }
    }
}
