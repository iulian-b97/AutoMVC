using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.RoleAssignment
{
    public class RoleAssignmentCommand : IRequest<RoleAssignmentCommandResponse>
    {
        public string RoleName { get; set; }
        public string UserId { get; set; }
    }
}
