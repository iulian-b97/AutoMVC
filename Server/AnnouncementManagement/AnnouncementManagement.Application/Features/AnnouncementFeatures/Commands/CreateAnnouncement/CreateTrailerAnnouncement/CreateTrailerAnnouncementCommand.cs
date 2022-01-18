using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement
{
    public class CreateTrailerAnnouncementCommand : IRequest<CreateTrailerAnnouncementCommandResponse>
    {
        public AnnouncementRequest Announcement { get; set; }
        public TrailerRequest Trailer { get; set; }
    }
}
