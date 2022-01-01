using MediatR;


namespace IdentityManagement.Application.Features.Administration.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<CreateRoleCommandResponse>
    {
        public string RoleName { get; set; }
    }
}
