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
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Body { get; set; }
        public string ColorBody { get; set; }
        public int NumberDoors { get; set; }
    }
}
