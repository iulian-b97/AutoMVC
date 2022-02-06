using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Models.Requests;
using AnnouncementManagement.Application.Models.Responses;
using AnnouncementManagement.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementManagement.Infrastructure.Persistence.Repositories
{
    public class SellerRepository : BaseRepository<Seller>, ISellerRepository
    {
        private readonly IMapper _mapper;

        public SellerRepository(AnnouncementContext _context, IMapper mapper) : base(_context)
        {
            _mapper = mapper;
        }


        public async Task<IEnumerable<Seller>> GetAllSellersAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Username)
               .ToListAsync();
        }

        public async Task<Seller> GetSellerByIdAsync(string sellerId)
        {
            return await FindByCondition(x => x.Id.Equals(sellerId))
                .FirstOrDefaultAsync();
        }

        public async Task<SellerResponse> CreateSeller(SellerRequest request)
        {
            if (request != null)
            {
                Seller seller = _mapper.Map<Seller>(request);
                seller.Id = Guid.NewGuid().ToString();
                Create(seller);
                await _context.SaveChangesAsync();
                return _mapper.Map<SellerResponse>(seller);
            }

            return null;
        }

        public void UpdateAnnouncement(Seller seller)
        {
            UpdateAnnouncement(seller);
        }

        public void DeleteAnnouncement(Seller seller)
        {
            DeleteAnnouncement(seller);
        }
    }
}
