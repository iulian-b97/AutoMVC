using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommand : IRequest<CreateTruckAnnouncementCommandResponse>
    {
        public AnnouncementRequest Announcement { get; set; }
        public TruckRequest Truck { get; set; }
    }
}
