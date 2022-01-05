using IdentityManagement.Application.Models;
using MediatR;


namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommand : IRequest<AuthResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
