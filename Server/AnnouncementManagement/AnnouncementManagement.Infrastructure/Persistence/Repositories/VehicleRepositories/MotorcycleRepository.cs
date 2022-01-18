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
    public class MotorcycleRepository : BaseRepository<Motorcycle>, IMotorcycleRepository
    {
        private readonly IMapper _mapper;

        public MotorcycleRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Motorcycle>> GetAllMotorcyclesAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Mark)
               .ToListAsync();
        }

        public async Task<Motorcycle> GetMotorcycleByIdAsync(string motorcycleId)
        {
            return await FindByCondition(x => x.Id.Equals(motorcycleId))
                .FirstOrDefaultAsync();
        }

        public async Task<MotorcycleResponse> CreateMotorcycle(MotorcycleRequest request)
        {
            Motorcycle motorcycle = _mapper.Map<Motorcycle>(request);
            motorcycle.Id = Guid.NewGuid().ToString();

            Create(motorcycle);

            await _context.SaveChangesAsync();

            return _mapper.Map<MotorcycleResponse>(motorcycle);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }
    }
}
