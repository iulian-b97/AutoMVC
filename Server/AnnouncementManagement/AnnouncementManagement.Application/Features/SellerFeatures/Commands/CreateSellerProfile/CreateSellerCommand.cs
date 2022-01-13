using MediatR;


namespace AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile
{
    public class CreateSellerCommand : IRequest<SellerDto>
    {
        public SellerDto Seller { get; set; }
      
    }
}
