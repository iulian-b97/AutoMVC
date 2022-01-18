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
    public class TrailerRepository : BaseRepository<Trailer>, ITrailerRepository
    {
        private readonly IMapper _mapper;

        public TrailerRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Trailer>> GetAllTrailersAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Mark)
               .ToListAsync();
        }

        public async Task<Trailer> GetTrailerByIdAsync(string trailerId)
        {
            return await FindByCondition(x => x.Id.Equals(trailerId))
                .FirstOrDefaultAsync();
        }

        public async Task<TrailerResponse> CreateTrailer(TrailerRequest request)
        {
            Trailer trailer = _mapper.Map<Trailer>(request);
            trailer.Id = Guid.NewGuid().ToString();

            Create(trailer);

            await _context.SaveChangesAsync();

            return _mapper.Map<TrailerResponse>(trailer);
        }

        public void UpdateTrailer(Trailer trailer)
        {
            Update(trailer);
        }

        public void DeleteTrailer(Trailer trailer)
        {
            Delete(trailer);
        }
    }
}
