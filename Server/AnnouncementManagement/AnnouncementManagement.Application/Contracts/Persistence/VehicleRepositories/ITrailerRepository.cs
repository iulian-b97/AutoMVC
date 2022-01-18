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
    public interface ITrailerRepository : IBaseRepository<Trailer>
    {
        Task<IEnumerable<Trailer>> GetAllTrailersAsync();
        Task<Trailer> GetTrailerByIdAsync(string trailerId);
        Task<TrailerResponse> CreateTrailer(TrailerRequest request);
        void UpdateTrailer(Trailer trailer);
        void DeleteTrailer(Trailer trailer);
    }
}
