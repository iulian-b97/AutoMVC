using AnnouncementManagement.Domain.Entities;
using AnnouncementManagement.Infrastructure.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile
{
    public class CreateSellerCommandHandler : IRequestHandler<CreateSellerCommand, SellerDto>
    {
        private readonly IMapper _mapper;
        private readonly AnnouncementContext _context;

        public CreateSellerCommandHandler(IMapper mapper, AnnouncementContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<SellerDto> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            Seller seller = new Seller
            {
                Username = request.Seller.Username,
                Email = request.Seller.Email,
                Phone = request.Seller.Phone,
                Country = request.Seller.Country
            };

            seller.Id = Guid.NewGuid().ToString();

            await _context.Sellers.AddAsync(seller);
            await _context.SaveChangesAsync();

            return _mapper.Map<SellerDto>(seller);
        }
    }
}
