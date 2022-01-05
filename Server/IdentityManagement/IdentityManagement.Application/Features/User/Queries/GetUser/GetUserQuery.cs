using IdentityManagement.Domain.Entities;
using MediatR;


namespace IdentityManagement.Application.Features.User.Queries.GetUser
{
    public class GetUserQuery : IRequest<ApplicationUser>
    {
        public string UserId { get; set; }
    }
}
