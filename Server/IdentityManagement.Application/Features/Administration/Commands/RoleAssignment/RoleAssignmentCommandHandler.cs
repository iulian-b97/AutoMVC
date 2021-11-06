using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.RoleAssignment
{
    public class RoleAssignmentCommandHandler : IRequestHandler<RoleAssignmentCommand, RoleAssignmentCommandResponse>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleAssignmentCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<RoleAssignmentCommandResponse> Handle(RoleAssignmentCommand request, CancellationToken cancellationToken)
        {
            var roleAssignmentCommandResponse = new RoleAssignmentCommandResponse();

            var validator = new RoleAssignmentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                roleAssignmentCommandResponse.Success = false;
                roleAssignmentCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    roleAssignmentCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (roleAssignmentCommandResponse.Success)
            {
                var user = await _userManager.FindByIdAsync(request.UserId);

                if(user == null)
                {
                    roleAssignmentCommandResponse.Success = false;
                    roleAssignmentCommandResponse.Message = "User doesn`t exist.";
                }
                else
                {
                    var getRoles = await _userManager.GetRolesAsync(user);
                    await _userManager.RemoveFromRolesAsync(user, getRoles);
                    await _userManager.AddToRoleAsync(user, request.RoleName);
                    roleAssignmentCommandResponse.Message = "Role assignment with success!";
                }
            }

            return roleAssignmentCommandResponse;
        }
    }
}
