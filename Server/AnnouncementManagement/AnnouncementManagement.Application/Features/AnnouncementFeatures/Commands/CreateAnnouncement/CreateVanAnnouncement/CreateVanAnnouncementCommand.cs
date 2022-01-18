using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using MediatR;


namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommand : IRequest<CreateVanAnnouncementCommandResponse>
    {
        public AnnouncementResponse Announcement { get; set; }
        public VanResponse Van { get; set; }
    }
}
