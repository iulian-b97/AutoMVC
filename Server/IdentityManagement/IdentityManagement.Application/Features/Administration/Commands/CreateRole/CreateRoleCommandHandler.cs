using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, CreateRoleCommandResponse>
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var createRoleCommandResponse = new CreateRoleCommandResponse();

            var validator = new CreateRoleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createRoleCommandResponse.Success = false;
                createRoleCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createRoleCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createRoleCommandResponse.Success)
            {
                var identityRole = new IdentityRole
                {
                    Name = request.RoleName
                };
                var result = await _roleManager.CreateAsync(identityRole);

                if(result == null)
                {
                    createRoleCommandResponse.Success = false;
                    createRoleCommandResponse.Message = "Name is null.";
                }
                else
                {
                    createRoleCommandResponse.Message = "Role create with success!";
                }
            }

            return createRoleCommandResponse;
        }
    }
}
