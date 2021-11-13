using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest<DeleteRoleCommandResponse>
    {
        public string RoleId { get; set; }
    }
}
