using AnnouncementManagement.Application.Contracts.Persistence;
using AnnouncementManagement.Application.Features.SellerFeatures.Commands.CreateSellerProfile;
using AnnouncementManagement.Application.Models.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile
{
    public class CreateSellerCommandHandler : IRequestHandler<CreateSellerCommand, CreateSellerCommandResponse>
    {
        private readonly ISellerRepository _repository;

        public CreateSellerCommandHandler(ISellerRepository repository)
        {
            _repository = repository;
        }

        public async Task<CreateSellerCommandResponse> Handle(CreateSellerCommand request, CancellationToken cancellationToken)
        {
            CreateSellerCommandResponse createSellerCommandResponse = new CreateSellerCommandResponse();

            SellerResponse seller = await _repository.CreateSeller(request.Seller);
            createSellerCommandResponse.Seller = seller;

            return createSellerCommandResponse;
        }
    }
}
