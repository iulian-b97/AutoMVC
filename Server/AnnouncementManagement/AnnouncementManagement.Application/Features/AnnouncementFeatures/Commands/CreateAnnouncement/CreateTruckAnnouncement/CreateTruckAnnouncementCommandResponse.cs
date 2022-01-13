using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommandResponse
    {
        public AnnouncementDto Announcement { get; set; }
        public TruckDto Truck { get; set; }
    }
}
