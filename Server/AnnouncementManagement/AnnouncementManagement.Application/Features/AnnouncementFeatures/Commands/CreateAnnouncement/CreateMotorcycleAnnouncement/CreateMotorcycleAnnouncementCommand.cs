using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using MediatR;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommand : IRequest<CreateMotorcycleAnnouncementCommandResponse>
    {
        public AnnouncementDto Announcement { get; set; }
        public MotorcycleDto Motorcycle { get; set; }
    }
}
