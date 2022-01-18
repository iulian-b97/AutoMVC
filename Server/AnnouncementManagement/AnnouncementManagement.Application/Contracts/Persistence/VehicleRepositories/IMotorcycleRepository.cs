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
    public interface IMotorcycleRepository : IBaseRepository<Motorcycle>
    {
        Task<IEnumerable<Motorcycle>> GetAllMotorcyclesAsync();
        Task<Motorcycle> GetMotorcycleByIdAsync(string motorcycleId);
        Task<MotorcycleResponse> CreateMotorcycle(MotorcycleRequest request);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(Motorcycle motorcycle);
    }
}
