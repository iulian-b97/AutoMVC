using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommand : IRequest<CreateCarAnnouncementCommandResponse>
    {
        public AnnouncementRequest Announcement { get; set; }
        public CarRequest Car { get; set; }
    }
}
