using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<CreateRoleCommandResponse>
    {
        public string RoleName { get; set; }
    }
}
