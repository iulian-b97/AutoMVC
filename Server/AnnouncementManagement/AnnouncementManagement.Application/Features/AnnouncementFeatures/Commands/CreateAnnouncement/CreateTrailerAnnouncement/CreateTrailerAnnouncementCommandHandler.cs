using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement
{
    public class CreateTrailerAnnouncementCommandHandler : IRequestHandler<CreateTrailerAnnouncementCommand, CreateTrailerAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateTrailerAnnouncementCommandHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateTrailerAnnouncementCommandResponse> Handle(CreateTrailerAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTrailerAnnouncementCommandResponse createTrailerCommandResponse = new CreateTrailerAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _repository.AddAnnouncement(request.Announcement);
            createTrailerCommandResponse.Announcement = announcement;
            createTrailerCommandResponse.Trailer = await _repository.AddTrailer(request.Trailer, announcement.Id);

            return createTrailerCommandResponse;
        }
    }
}
