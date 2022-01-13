using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement;
using AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AutoMapper;


namespace AnnouncementManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Seller, SellerDto>();
            CreateMap<Announcement, AnnouncementDto>();
            CreateMap<Car, CarDto>();
            CreateMap<Motorcycle, MotorcycleDto>();
            CreateMap<Truck, TruckDto>();
            CreateMap<Van, VanDto>();
            CreateMap<Trailer, TrailerDto>();
        }
    }
}
