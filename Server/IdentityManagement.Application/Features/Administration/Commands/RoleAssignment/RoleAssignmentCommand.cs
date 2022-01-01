using MediatR;


namespace IdentityManagement.Application.Features.Administration.Commands.RoleAssignment
{
    public class RoleAssignmentCommand : IRequest<RoleAssignmentCommandResponse>
    {
        public string RoleName { get; set; }
        public string UserId { get; set; }
    }
}
