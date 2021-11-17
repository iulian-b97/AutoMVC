using IdentityManagement.Application.Models;
using IdentityManagement.Application.Models.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommand : IRequest<AuthResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
