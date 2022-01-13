using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement
{
    public class CreateTruckAnnouncementCommandHandler : IRequestHandler<CreateTruckAnnouncementCommand, CreateTruckAnnouncementCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateTruckAnnouncementCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<CreateTruckAnnouncementCommandResponse> Handle(CreateTruckAnnouncementCommand request, CancellationToken cancellationToken)
        {
            CreateTruckAnnouncementCommandResponse createTruckCommandResponse = new CreateTruckAnnouncementCommandResponse();

            Announcement announcement = new Announcement
            {
                Title = request.Announcement.Title,
                Price = request.Announcement.Price,
                Description = request.Announcement.Description,
                SellerId = request.Announcement.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            Truck truck = new Truck
            {
                Mark = request.Truck.Mark,
                Model = request.Truck.Model,
                Year = request.Truck.Year,
                Km = request.Truck.Km,
                HP = request.Truck.HP,
                FuelType = request.Truck.FuelType,
                Cm3 = request.Truck.Cm3,
                Gearbox = request.Truck.Gearbox,
                Speeds = request.Truck.Speeds,
                Cylinders = request.Truck.Cylinders,
                Traction = request.Truck.Traction,
                Body = request.Truck.Body,
                ColorBody = request.Truck.ColorBody,
                Paint = request.Truck.Paint,
                NumberDoors = request.Truck.NumberDoors,
                NumberSeats = request.Truck.NumberSeats,
                Weight = request.Truck.Weight,
                AnnouncementId = announcement.Id
            };
            truck.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.Trucks.AddAsync(truck);
            await _context.SaveChangesAsync();

            createTruckCommandResponse.Announcement = _mapper.Map<AnnouncementDto>(announcement);
            createTruckCommandResponse.Truck = _mapper.Map<TruckDto>(truck);

            return createTruckCommandResponse;
        }
    }
}
