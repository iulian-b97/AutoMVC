using AnnouncementManagement.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile
{
    public class CreateSellerCommandHandler : IRequestHandler<CreateSellerCommand, SellerDto>
    {
        private readonly IAnnouncementRepository _repository;

        public CreateSellerCommandHandler(IAnnouncementRepository repository)
        {
            _repository = repository;
        }

        public async Task<SellerDto> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddSeller(request.Seller);
        }
    }
}
