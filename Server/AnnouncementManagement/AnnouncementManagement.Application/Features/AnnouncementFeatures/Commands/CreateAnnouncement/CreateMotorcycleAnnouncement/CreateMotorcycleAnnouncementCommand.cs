using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using MediatR;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommand : IRequest<CreateMotorcycleAnnouncementCommandResponse>
    {
        public AnnouncementRequest Announcement { get; set; }
        public MotorcycleRequest Motorcycle { get; set; }
    }
}
