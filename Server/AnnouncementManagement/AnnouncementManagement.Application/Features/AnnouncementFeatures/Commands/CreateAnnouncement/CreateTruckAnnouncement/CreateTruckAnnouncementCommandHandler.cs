using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
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

            AnnouncementResponse announcement = new AnnouncementResponse
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price
            };
            TruckResponse truck = new TruckResponse
            {
                Mark = request.Mark,
                Model = request.Model,
                Year = request.Year,
                Body = request.Body,
                ColorBody = request.ColorBody,
                Km = request.Km,
                HP = request.HP,
                FuelType = request.FuelType,
                Cm3 = request.Cm3,
                Gearbox = request.Gearbox,
                Speeds = request.Speeds,
                Cylinders = request.Cylinders,
                Traction = request.Traction,
                Paint = request.Paint,
                NumberDoors = request.NumberDoors,
                NumberSeats = request.NumberSeats,
                Weight = request.Weight
            };

            createTruckCommandResponse.Announcement = await _announcementRepo.CreateAnnouncement(announcement);
            createTruckCommandResponse.Truck = await _truckRepo.CreateTruck(truck);

            return createTruckCommandResponse;
        }
    }
}
