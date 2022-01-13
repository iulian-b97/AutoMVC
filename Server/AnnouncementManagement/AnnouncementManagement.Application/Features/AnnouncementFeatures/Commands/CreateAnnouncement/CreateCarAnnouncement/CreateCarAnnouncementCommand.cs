using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommand : IRequest<CreateCarAnnouncementCommandResponse>
    {
        public AnnouncementDto Announcement { get; set; }
        public CarDto Car { get; set; }
    }
}
