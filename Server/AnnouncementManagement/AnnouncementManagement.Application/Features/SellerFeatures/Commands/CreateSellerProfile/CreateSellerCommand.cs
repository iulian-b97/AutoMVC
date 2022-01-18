using AnnouncementManagement.Application.Features.SellerFeatures.Commands.CreateSellerProfile;
using AnnouncementManagement.Application.Models.Requests;
using MediatR;


namespace AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile
{
    public class CreateSellerCommand : IRequest<CreateSellerCommandResponse>
    {
        public SellerRequest Seller { get; set; }  
    }
}
