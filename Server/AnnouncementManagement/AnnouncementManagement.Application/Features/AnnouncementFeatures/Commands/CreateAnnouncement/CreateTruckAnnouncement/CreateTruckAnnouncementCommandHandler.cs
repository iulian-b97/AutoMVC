using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommandHandler : IRequestHandler<CreateTruckAnnouncementCommand, CreateTruckAnnouncementCommandResponse>
    {
        private readonly IAnnouncementRepository _announcementRepo;
        private readonly ITruckRepository _truckRepo;

        public CreateTruckAnnouncementCommandHandler(IAnnouncementRepository announcementRepo, ITruckRepository truckRepo)
        {
            _announcementRepo = announcementRepo;
            _truckRepo = truckRepo;
        }

        public async Task<CreateTruckAnnouncementCommandResponse> Handle(CreateTruckAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTruckAnnouncementCommandResponse createTruckCommandResponse = new CreateTruckAnnouncementCommandResponse();

            /*
            AnnouncementResponse announcement = await _announcementRepo.CreateAnnouncement(request.Announcement);
            createTruckCommandResponse.Announcement = announcement;
            createTruckCommandResponse.Truck = await _truckRepo.CreateTruck(request.Truck); */

            return createTruckCommandResponse;
        }
    }
}
