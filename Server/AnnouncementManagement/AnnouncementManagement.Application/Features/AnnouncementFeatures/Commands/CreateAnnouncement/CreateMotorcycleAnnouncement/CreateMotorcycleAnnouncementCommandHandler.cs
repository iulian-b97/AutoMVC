using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement
{
    public class CreateMotorcycleAnnouncementCommandHandler : IRequestHandler<CreateMotorcycleAnnouncementCommand, CreateMotorcycleAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateMotorcycleAnnouncementCommandHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateMotorcycleAnnouncementCommandResponse> Handle(CreateMotorcycleAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateMotorcycleAnnouncementCommandResponse createMotorcycleCommandResponse = new CreateMotorcycleAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _repository.AddAnnouncement(request.Announcement);
            createMotorcycleCommandResponse.Announcement = announcement;
            createMotorcycleCommandResponse.Motorcycle = await _repository.AddMotorcycle(request.Motorcycle, announcement.Id);

            return createMotorcycleCommandResponse;
        }
    }
}
