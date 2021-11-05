using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommandValidator : AbstractValidator<UserLoginCommand>
    {
        public UserLoginCommandValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.")
                .EmailAddress().WithMessage("{PropertyName} is not a valid email address.");

            RuleFor(p => p.Password)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters length.");
        }
    }
}
