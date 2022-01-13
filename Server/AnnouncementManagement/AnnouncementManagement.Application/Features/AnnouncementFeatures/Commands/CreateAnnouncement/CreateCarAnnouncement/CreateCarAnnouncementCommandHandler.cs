using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement
{
    public class CreateCarAnnouncementCommandHandler : IRequestHandler<CreateCarAnnouncementCommand, CreateCarAnnouncementCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateCarAnnouncementCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<CreateCarAnnouncementCommandResponse> Handle(CreateCarAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateCarAnnouncementCommandResponse createCarCommandResponse = new CreateCarAnnouncementCommandResponse();

            Announcement announcement = new Announcement
            {
                Title = request.Announcement.Title,
                Price = request.Announcement.Price,
                Description = request.Announcement.Description,
                SellerId = request.Announcement.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            Car car = new Car
            {
                Mark = request.Car.Mark,
                Model = request.Car.Model,
                Year = request.Car.Year,
                Km = request.Car.Km,
                HP = request.Car.HP,
                FuelType = request.Car.FuelType,
                Cm3 = request.Car.Cm3,
                Gearbox = request.Car.Gearbox,
                Speeds = request.Car.Speeds,
                Cylinders = request.Car.Cylinders,
                Traction = request.Car.Traction,
                Body = request.Car.Body,
                ColorBody = request.Car.ColorBody,
                Paint = request.Car.Paint,
                NumberDoors = request.Car.NumberDoors,
                NumberSeats = request.Car.NumberSeats,
                Weight = request.Car.Weight,
                AnnouncementId = announcement.Id
            };
            car.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();

            createCarCommandResponse.Announcement = _mapper.Map<AnnouncementDto>(announcement);
            createCarCommandResponse.Car = _mapper.Map<CarDto>(car);

            return createCarCommandResponse;
        }
    }
}
