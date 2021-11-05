using IdentityManagement.Application.Models.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken
{
    public class RefreshTokenCommand : IRequest<RefreshTokenCommandResponse>
    {
        public TokenRequest TokenRequest { get; set; }
    }
}
