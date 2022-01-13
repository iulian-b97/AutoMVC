using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
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
        public AnnouncementDto Announcement { get; set; }
        public TrailerDto Trailer { get; set; }
    }
}
