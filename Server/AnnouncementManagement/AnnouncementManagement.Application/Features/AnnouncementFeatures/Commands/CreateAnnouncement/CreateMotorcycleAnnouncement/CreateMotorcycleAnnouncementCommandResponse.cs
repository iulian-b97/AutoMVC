using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommandResponse
    {
        public AnnouncementDto Announcement { get; set; }
        public MotorcycleDto Motorcycle { get; set; }
    }
}
