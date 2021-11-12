using IdentityManagement.Application.Features.Administration.Commands.CreateRole;
using IdentityManagement.Application.Features.Administration.Commands.DeleteRole;
using IdentityManagement.Application.Features.Administration.Commands.RoleAssignment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdministrationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createRole", Name = "CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleCommand createRoleCommand)
        {
            var response = await _mediator.Send(createRoleCommand);
            return Ok(response);
        }

        [HttpPost("roleAssignment", Name = "RoleAssignment")]
        public async Task<IActionResult> RoleAssignment([FromBody] RoleAssignmentCommand roleAssignmentCommand)
        {
            var response = await _mediator.Send(roleAssignmentCommand);
            return Ok(response);
        }

        [HttpPost("deleteRole", Name = "DeleteRole")]
        public async Task<IActionResult> DeleteRole([FromBody] DeleteRoleCommand deleteRoleCommand)
        {
            var response = await _mediator.Send(deleteRoleCommand);
            return Ok(response);
        }
    }
}
