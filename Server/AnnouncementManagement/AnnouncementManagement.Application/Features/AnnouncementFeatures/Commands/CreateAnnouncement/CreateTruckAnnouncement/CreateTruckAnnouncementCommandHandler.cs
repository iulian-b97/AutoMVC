using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommandHandler : IRequestHandler<CreateTruckAnnouncementCommand, CreateTruckAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateTruckAnnouncementCommandHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateTruckAnnouncementCommandResponse> Handle(CreateTruckAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTruckAnnouncementCommandResponse createTruckCommandResponse = new CreateTruckAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _repository.AddAnnouncement(request.Announcement);
            createTruckCommandResponse.Announcement = announcement;
            createTruckCommandResponse.Truck = await _repository.AddTruck(request.Truck, announcement.Id);

            return createTruckCommandResponse;
        }
    }
}
