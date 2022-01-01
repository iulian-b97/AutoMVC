using FluentValidation;


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
