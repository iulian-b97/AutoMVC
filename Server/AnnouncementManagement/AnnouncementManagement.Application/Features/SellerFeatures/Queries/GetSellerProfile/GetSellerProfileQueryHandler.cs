using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile;
using AnnouncementManagement.Application.Models.Requests;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.SellerFeatures.Queries.GetSellerProfile
{
    public class GetSellerProfileQueryHandler : IRequestHandler<GetSellerProfileQuery, SellerRequest>
    {
        private readonly IAnnouncementRepository _repository;

        public GetSellerProfileQueryHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<SellerRequest> Handle(GetSellerProfileQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
