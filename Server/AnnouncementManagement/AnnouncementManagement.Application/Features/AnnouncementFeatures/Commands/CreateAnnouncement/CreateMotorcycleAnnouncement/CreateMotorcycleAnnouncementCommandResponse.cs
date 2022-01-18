using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommandResponse
    {
        public AnnouncementResponse Announcement { get; set; }
        public MotorcycleResponse Motorcycle { get; set; }
    }
}
