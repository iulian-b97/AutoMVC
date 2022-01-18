using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement;
using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AutoMapper;


namespace AnnouncementManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SellerRequest, Seller>();
            CreateMap<Seller, SellerResponse>();

            CreateMap<AnnouncementRequest, Announcement>();
            CreateMap<Announcement, AnnouncementResponse>();

            CreateMap<CarRequest, Car>();
            CreateMap<Car, CarResponse>();

            CreateMap<MotorcycleRequest, Motorcycle>();
            CreateMap<Motorcycle, MotorcycleResponse>();

            CreateMap<TruckRequest, Truck>();
            CreateMap<Truck, TruckResponse>();

            CreateMap<VanRequest, Van>();
            CreateMap<Van, VanResponse>();

            CreateMap<TrailerRequest, Trailer>();
            CreateMap<Trailer, TrailerResponse>();
        }
    }
}
