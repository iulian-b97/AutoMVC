using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommand : IRequest<CreateVanAnnouncementCommandResponse>
    {
        public AnnouncementDto Announcement { get; set; }
        public VanDto Van { get; set; }
    }
}
