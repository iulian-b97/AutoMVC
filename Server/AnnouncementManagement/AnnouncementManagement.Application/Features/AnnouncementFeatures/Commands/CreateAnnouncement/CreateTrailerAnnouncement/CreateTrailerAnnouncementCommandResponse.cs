using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement
{
    public class CreateTrailerAnnouncementCommandResponse
    {
        public AnnouncementResponse Announcement { get; set; }
        public TrailerResponse Trailer { get; set; }
    }
}
