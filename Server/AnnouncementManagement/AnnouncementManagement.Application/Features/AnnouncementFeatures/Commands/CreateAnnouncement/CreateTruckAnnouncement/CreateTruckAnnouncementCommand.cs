using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommand : IRequest<CreateTruckAnnouncementCommandResponse>
    {
        public AnnouncementDto Announcement { get; set; }
        public TruckDto Truck { get; set; }
    }
}
