using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AnnouncementManagement.Application.Contracts.Persistence
{
    public interface IAnnouncementRepository : IBaseRepository<Announcement>
    {
        Task<IEnumerable<Announcement>> GetAllAnnouncementsAsync();
        Task<Announcement> GetAnnouncementByIdAsync(string announcementId);
        Task<AnnouncementResponse> CreateAnnouncement(AnnouncementRequest request);
        void UpdateAnnouncement(Announcement announcement);
        void DeleteAnnouncement(Announcement announcement);
    }
}
