using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommandHandler : IRequestHandler<CreateCarAnnouncementCommand, CreateCarAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _announcementRepo;
        private readonly ICarRepository _carRepo;

        public CreateCarAnnouncementCommandHandler(IAnnouncementRepository announcementRepo, ICarRepository carRepo) 
        {
            _announcementRepo = announcementRepo;
            _carRepo = carRepo;
        }

        public async Task<CreateCarAnnouncementCommandResponse> Handle(CreateCarAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateCarAnnouncementCommandResponse createCarCommandResponse = new CreateCarAnnouncementCommandResponse();

            AnnouncementResponse announcement = await _announcementRepo.CreateAnnouncement(request.Announcement);
            createCarCommandResponse.Announcement = announcement;
            createCarCommandResponse.Car = await _carRepo.CreateCar(request.Car);

            return createCarCommandResponse;
        }
    }
}
