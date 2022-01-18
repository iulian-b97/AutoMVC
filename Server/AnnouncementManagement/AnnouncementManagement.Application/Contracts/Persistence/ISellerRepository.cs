using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Contracts.Persistence
{
    public interface ISellerRepository : IBaseRepository<Seller>
    {
        Task<IEnumerable<Seller>> GetAllSellersAsync();
        Task<Seller> GetSellerByIdAsync(string sellerId);
        Task<SellerResponse> CreateSeller(SellerRequest request);
        void UpdateAnnouncement(Seller seller);
        void DeleteAnnouncement(Seller seller);
    }
}
