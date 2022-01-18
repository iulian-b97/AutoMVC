using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
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

            AnnouncementResponse announcement = await _announcementRepo.CreateAnnouncement(request.Announcement);
            createTrailerCommandResponse.Announcement = announcement;
            createTrailerCommandResponse.Trailer = await _trailerRepo.CreateTrailer(request.Trailer);

            return createTrailerCommandResponse;
        }
    }
}
