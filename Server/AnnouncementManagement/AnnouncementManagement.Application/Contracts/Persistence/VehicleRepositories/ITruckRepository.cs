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
    public interface ITruckRepository : IBaseRepository<Truck>
    {
        Task<IEnumerable<Truck>> GetAllTrucksAsync();
        Task<Truck> GetTruckByIdAsync(string truckId);
        Task<TruckResponse> CreateTruck(TruckRequest request);
        void UpdateTruck(Truck truck);
        void DeleteTruck(Truck truck);
    }
}
