using MediatR;


namespace IdentityManagement.Application.Features.Administration.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest<DeleteRoleCommandResponse>
    {
        public string RoleId { get; set; }
    }
}
