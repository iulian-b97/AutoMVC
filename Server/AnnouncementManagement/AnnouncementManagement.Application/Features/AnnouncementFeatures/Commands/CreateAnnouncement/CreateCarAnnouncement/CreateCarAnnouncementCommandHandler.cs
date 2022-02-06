using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
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

            AnnouncementResponse announcement = new AnnouncementResponse
            {
                Title = request.Title,
                Description = request.Description,
                Price = request.Price
            };
            CarResponse car = new CarResponse
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

            createCarCommandResponse.Announcement = await _announcementRepo.CreateAnnouncement(announcement);
            createCarCommandResponse.Car = await _carRepo.CreateCar(car);

            return createCarCommandResponse;
        }
    }
}
