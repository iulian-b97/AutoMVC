using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement
{
    public class CreateVanAnnouncementCommandHandler : IRequestHandler<CreateVanAnnouncementCommand, CreateVanAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateVanAnnouncementCommandHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateVanAnnouncementCommandResponse> Handle(CreateVanAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateVanAnnouncementCommandResponse createVanCommandResponse = new CreateVanAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _repository.AddAnnouncement(request.Announcement);
            createVanCommandResponse.Announcement = announcement;
            createVanCommandResponse.Van = await _repository.AddVan(request.Van, announcement.Id);

            return createVanCommandResponse;
        }
    }
}
