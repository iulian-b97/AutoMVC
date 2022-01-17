using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement;
using AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AutoMapper;
using System;
using System.Threading.Tasks;


namespace AnnouncementManagement.Infrastructure.Persistence.Repositories
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        private readonly AnnouncementContext _context;
        private readonly IMapper _mapper;

        public AnnouncementRepository(AnnouncementContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<SellerDto> AddSeller(SellerDto model)
        {
            Seller seller = new Seller
            {
                Username = model.Username,
                Email = model.Email,
                Phone = model.Phone,
                Country = model.Country
            };
            seller.Id = Guid.NewGuid().ToString();

            await _context.Sellers.AddAsync(seller);
            await _context.SaveChangesAsync();

            return _mapper.Map<SellerDto>(seller);
        }

        public async Task<AnnouncementResponse> AddAnnouncement(AnnouncementDto model)
        {
            Announcement announcement = new Announcement
            {
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                SellerId = model.SellerId
            };
            announcement.Id = Guid.NewGuid().ToString();

            await _context.Announcements.AddAsync(announcement);
            await _context.SaveChangesAsync();

            return _mapper.Map<AnnouncementResponse>(announcement);
        }

        public async Task<CarDto> AddCar(CarDto model, string announcementId)
        {
            Car car = new Car
            {
                Mark = model.Mark,
                Model = model.Model,
                Year = model.Year,
                Km = model.Km,
                HP = model.HP,
                FuelType = model.FuelType,
                Cm3 = model.Cm3,
                Gearbox = model.Gearbox,
                Speeds = model.Speeds,
                Cylinders = model.Cylinders,
                Traction = model.Traction,
                Body = model.Body,
                ColorBody = model.ColorBody,
                Paint = model.Paint,
                NumberDoors = model.NumberDoors,
                NumberSeats = model.NumberSeats,
                Weight = model.Weight,
                AnnouncementId = announcementId
            };
            car.Id = Guid.NewGuid().ToString();

            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();

            return _mapper.Map<CarDto>(car);
        }

        public async Task<MotorcycleDto> AddMotorcycle(MotorcycleDto model, string announcementId)
        {
            Motorcycle motorcycle = new Motorcycle
            {
                Mark = model.Mark,
                Model = model.Model,
                Year = model.Year,
                Km = model.Km,
                HP = model.HP,
                Cm3 = model.Cm3,
                Gearbox = model.Gearbox,
                Body = model.Body,
                ColorBody = model.ColorBody,
                AnnouncementId = announcementId
            };
            motorcycle.Id = Guid.NewGuid().ToString();

            await _context.Motorcycles.AddAsync(motorcycle);
            await _context.SaveChangesAsync();

            return _mapper.Map<MotorcycleDto>(motorcycle);
        }

        public async Task<TruckDto> AddTruck(TruckDto model, string announcementId)
        {
            Truck truck = new Truck
            {
                Mark = model.Mark,
                Model = model.Model,
                Year = model.Year,
                Km = model.Km,
                HP = model.HP,
                FuelType = model.FuelType,
                Cm3 = model.Cm3,
                Gearbox = model.Gearbox,
                Speeds = model.Speeds,
                Cylinders = model.Cylinders,
                Traction = model.Traction,
                Body = model.Body,
                ColorBody = model.ColorBody,
                Paint = model.Paint,
                NumberDoors = model.NumberDoors,
                NumberSeats = model.NumberSeats,
                Weight = model.Weight,
                AnnouncementId = announcementId
            };
            truck.Id = Guid.NewGuid().ToString();

            await _context.Trucks.AddAsync(truck);
            await _context.SaveChangesAsync();

            return _mapper.Map<TruckDto>(truck);
        }

        public async Task<VanDto> AddVan(VanDto model, string announcementId)
        {
            Van van = new Van
            {
                Mark = model.Mark,
                Model = model.Model,
                Year = model.Year,
                Km = model.Km,
                HP = model.HP,
                Cm3 = model.Cm3,
                Gearbox = model.Gearbox,
                Speeds = model.Speeds,
                Cylinders = model.Cylinders,
                Traction = model.Traction,
                Body = model.Body,
                ColorBody = model.ColorBody,
                Paint = model.Paint,
                NumberDoors = model.NumberDoors,
                NumberSeats = model.NumberSeats,
                Weight = model.Weight,
                AnnouncementId = announcementId
            };
            van.Id = Guid.NewGuid().ToString();

            await _context.Vans.AddAsync(van);
            await _context.SaveChangesAsync();

            return _mapper.Map<VanDto>(van);
        }

        public async Task<TrailerDto> AddTrailer(TrailerDto model, string announcementId)
        {
            Trailer trailer = new Trailer
            {
                Mark = model.Mark,
                Model = model.Model,
                Year = model.Year,
                Body = model.Body,
                ColorBody = model.ColorBody,
                NumberDoors = model.NumberDoors,
                AnnouncementId = announcementId
            };
            trailer.Id = Guid.NewGuid().ToString();

            await _context.Trailers.AddAsync(trailer);
            await _context.SaveChangesAsync();

            return _mapper.Map<TrailerDto>(trailer);
        }    
    }
}
