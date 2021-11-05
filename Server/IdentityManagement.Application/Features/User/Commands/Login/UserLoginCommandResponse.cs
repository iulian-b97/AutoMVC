using IdentityManagement.Application.Models;
using IdentityManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommandResponse : BaseResponse
    {
        public UserLoginCommandResponse() : base()
        {

        }

        public AuthResult AuthResult { get; set; }
    }
}
