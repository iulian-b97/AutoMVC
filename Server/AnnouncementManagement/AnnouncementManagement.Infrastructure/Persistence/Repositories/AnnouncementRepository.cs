using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AnnouncementManagement.Infrastructure.Persistence.Repositories
{
    public class AnnouncementRepository : BaseRepository<Announcement> ,IAnnouncementRepository
    {
        private readonly IMapper _mapper;

        public AnnouncementRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Announcement>> GetAllAnnouncementsAsync()
        {
            return await FindAll()
                .OrderBy(x => x.Title)
                .ToListAsync();
        }

        public async Task<Announcement> GetAnnouncementByIdAsync(string announcementId)
        {
            return await FindByCondition(x => x.Id.Equals(announcementId))
                .FirstOrDefaultAsync();
        }

        public async Task<AnnouncementResponse> CreateAnnouncement(AnnouncementRequest request)
        {
            Announcement announcement = _mapper.Map<Announcement>(request);
            announcement.Id = Guid.NewGuid().ToString();

            Create(announcement);

            await _context.SaveChangesAsync();

            return _mapper.Map<AnnouncementResponse>(announcement);
        }

        public void UpdateAnnouncement(Announcement announcement)
        {
            Update(announcement);
        }

        public void DeleteAnnouncement(Announcement announcement)
        {
            Delete(announcement);
        }
    }
}
