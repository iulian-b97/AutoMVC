using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommandResponse
    {
        public AnnouncementDto Announcement { get; set; }
        public VanDto Van { get; set; }
    }
}
