using AnnouncementManagement.Application.Contracts.Persistence.VehicleRepositories;
using AnnouncementManagement.Application.Models.Requests.VehicleRequests;
using AnnouncementManagement.Application.Models.Responses.VehicleResponses;
using AnnouncementManagement.Domain.Entities.Vehicle;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Infrastructure.Persistence.Repositories.VehicleRepositories
{
    public class TruckRepository : BaseRepository<Truck>, ITruckRepository
    {
        private readonly IMapper _mapper;

        public TruckRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Truck>> GetAllTrucksAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Mark)
               .ToListAsync();
        }

        public async Task<Truck> GetTruckByIdAsync(string truckId)
        {
            return await FindByCondition(x => x.Id.Equals(truckId))
               .FirstOrDefaultAsync();
        }

        public async Task<TruckResponse> CreateTruck(TruckRequest request)
        {
            if (request != null)
            {
                Truck truck = _mapper.Map<Truck>(request);
                truck.Id = Guid.NewGuid().ToString();
                Create(truck);
                await _context.SaveChangesAsync();
                return _mapper.Map<TruckResponse>(truck);
            }

            return null;
        }

        public void UpdateTruck(Truck truck)
        {
            UpdateTruck(truck);
        }

        public void DeleteTruck(Truck truck)
        {
            Delete(truck);
        }
    }
}
