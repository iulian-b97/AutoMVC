using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommandHandler : IRequestHandler<CreateCarAnnouncementCommand, CreateCarAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateCarAnnouncementCommandHandler(IAnnouncementRepository repository) 
        {
            _repository = repository;
        }

        public async Task<CreateCarAnnouncementCommandResponse> Handle(CreateCarAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateCarAnnouncementCommandResponse createCarCommandResponse = new CreateCarAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _repository.AddAnnouncement(request.Announcement);
            createCarCommandResponse.Announcement = announcement;
            createCarCommandResponse.Car = await _repository.AddCar(request.Car, announcement.Id);

            return createCarCommandResponse;
        }
    }
}
