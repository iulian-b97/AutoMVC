using IdentityManagement.Application.Models;
using IdentityManagement.Application.Responses;


namespace IdentityManagement.Application.Features.User.Commands.Register
{
    public class UserRegistrationCommandResponse : BaseResponse
    {
        public UserRegistrationCommandResponse() : base()
        {

        }

        public AuthResult AuthResult { get; set; }
    }
}
