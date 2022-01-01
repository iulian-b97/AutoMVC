using FluentValidation;


namespace IdentityManagement.Application.Features.Administration.Commands.CreateRole
{
    public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p => p.RoleName)
              .NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull();
        }
    }
}
