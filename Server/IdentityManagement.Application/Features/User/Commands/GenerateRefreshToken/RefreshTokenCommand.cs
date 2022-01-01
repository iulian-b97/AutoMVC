using IdentityManagement.Application.Models;
using MediatR;


namespace IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken
{
    public class RefreshTokenCommand : IRequest<AuthResult>
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
