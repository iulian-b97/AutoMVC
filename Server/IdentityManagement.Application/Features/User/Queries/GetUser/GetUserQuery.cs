using IdentityManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Queries.GetUser
{
    public class GetUserQuery : IRequest<ApplicationUser>
    {
        public string UserId { get; set; }
    }
}
