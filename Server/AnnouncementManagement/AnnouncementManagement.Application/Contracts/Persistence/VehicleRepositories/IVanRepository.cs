using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using AnnouncementManagement.Domain.Entities.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories
{
    public interface IVanRepository : IBaseRepository<Van>
    {
        Task<IEnumerable<Van>> GetAllVansAsync();
        Task<Van> GetVanByIdAsync(string vanId);
        Task<VanResponse> CreateVan(VanRequest request);
        void UpdateVan(Van van);
        void DeleteVan(Van van);
    }
}
