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
    public class VanRepository : BaseRepository<Van>, IVanRepository
    {
        private readonly IMapper _mapper;

        public VanRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Van>> GetAllVansAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Mark)
               .ToListAsync();
        }

        public async Task<Van> GetVanByIdAsync(string vanId)
        {
            return await FindByCondition(x => x.Id.Equals(vanId))
                .FirstOrDefaultAsync();
        }

        public async Task<VanResponse> CreateVan(VanRequest request)
        {
            Van van = _mapper.Map<Van>(request);
            van.Id = Guid.NewGuid().ToString();

            Create(van);

            await _context.SaveChangesAsync();

            return _mapper.Map<VanResponse>(van);
        }

        public void UpdateVan(Van van)
        {
            Update(van);
        }

        public void DeleteVan(Van van)
        {
            Delete(van);
        }
    }
}
