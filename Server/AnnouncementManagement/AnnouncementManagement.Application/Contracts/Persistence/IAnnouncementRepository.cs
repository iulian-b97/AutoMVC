using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement;
using AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile;
using AnnouncementManagement.Application.Models.Responses.AnnouncementResponses;
using System.Threading.Tasks;


namespace AnnouncementManagement.Application.Contracts.Persistence
{
    public interface IAnnouncementRepository 
    {
        Task<SellerDto> AddSeller(SellerDto model);
        Task<AnnouncementResponse> AddAnnouncement(AnnouncementDto model);
        Task<CarDto> AddCar(CarDto model, string announcementId);
        Task<MotorcycleDto> AddMotorcycle(MotorcycleDto model, string announcementId);
        Task<TruckDto> AddTruck(TruckDto model, string announcementId);
        Task<VanDto> AddVan(VanDto model, string announcementId);
        Task<TrailerDto> AddTrailer(TrailerDto model, string announcementId);
    }
}
