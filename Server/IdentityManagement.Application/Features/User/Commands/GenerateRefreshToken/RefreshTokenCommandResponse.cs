using IdentityManagement.Application.Models;
using IdentityManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken
{
    public class RefreshTokenCommandResponse : BaseResponse
    {
        public RefreshTokenCommandResponse() : base()
        {

        }

        public AuthResult AuthResult { get; set; }
    }
}
