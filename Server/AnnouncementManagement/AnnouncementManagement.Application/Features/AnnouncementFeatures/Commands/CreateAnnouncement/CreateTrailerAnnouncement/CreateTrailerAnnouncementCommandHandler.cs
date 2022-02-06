using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement
{
    public class CreateTrailerAnnouncementCommandHandler : IRequestHandler<CreateTrailerAnnouncementCommand, CreateTrailerAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _announcementRepo;
        private readonly ITrailerRepository _trailerRepo;

        public CreateTrailerAnnouncementCommandHandler(IAnnouncementRepository announcementRepo, ITrailerRepository trailerRepo)
        {
            _announcementRepo = announcementRepo;
            _trailerRepo = trailerRepo;
        }

        public async Task<CreateTrailerAnnouncementCommandResponse> Handle(CreateTrailerAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTrailerAnnouncementCommandResponse createTrailerCommandResponse = new CreateTrailerAnnouncementCommandResponse();

            AnnouncementResponse announcement = new AnnouncementResponse
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price
            };
            TrailerResponse trailer = new TrailerResponse
            {
                Mark = request.Mark,
                Model = request.Model,
                Year = request.Year,
                Body = request.Body,
                ColorBody = request.ColorBody,
                NumberDoors = request.NumberDoors
            };

            createTrailerCommandResponse.Announcement = await _announcementRepo.CreateAnnouncement(announcement);
            createTrailerCommandResponse.Trailer = await _trailerRepo.CreateTrailer(trailer);

            return createTrailerCommandResponse;
        }
    }
}
