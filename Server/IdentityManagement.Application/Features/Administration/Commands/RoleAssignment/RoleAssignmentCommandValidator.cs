using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.Administration.Commands.RoleAssignment
{
    public class RoleAssignmentCommandValidator : AbstractValidator<RoleAssignmentCommand>
    {
        public RoleAssignmentCommandValidator()
        {
            RuleFor(p => p.RoleName)
              .NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull();
        }
    }
}
