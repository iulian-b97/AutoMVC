using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public DeleteRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var deleteRoleCommandResponse = new DeleteRoleCommandResponse();

            if(request.RoleId == null)
            {
                deleteRoleCommandResponse.Success = false;
                deleteRoleCommandResponse.Message = "RoleId is null.";
            }
            if(deleteRoleCommandResponse.Success)
            {
                var role = await _roleManager.FindByIdAsync(request.RoleId);

                if(role == null)
                {
                    deleteRoleCommandResponse.Success = false;
                    deleteRoleCommandResponse.Message = "Role doesn`t exist.";
                }
                else
                {
                    var result = await _roleManager.DeleteAsync(role);
                    deleteRoleCommandResponse.Message = "Role delete with success!";
                }
            }

            return deleteRoleCommandResponse;
        }
    }
}
