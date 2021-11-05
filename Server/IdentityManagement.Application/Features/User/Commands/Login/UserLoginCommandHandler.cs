using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand, UserLoginCommandResponse>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;

        public UserLoginCommandHandler(UserManager<ApplicationUser> userManager,
            IUserRepository userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task<UserLoginCommandResponse> Handle(UserLoginCommand request, CancellationToken cancellationToken)
        {
            var userLoginCommandResponse = new UserLoginCommandResponse();

            var validator = new UserLoginCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                userLoginCommandResponse.Success = false;
                userLoginCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    userLoginCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (userLoginCommandResponse.Success)
            {
                var existingUser = await _userManager.FindByEmailAsync(request.Email);
                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, request.Password);

                if(isCorrect)
                {
                    var jwtToken =  await _userRepository.GenerateJwtToken(existingUser);
                    userLoginCommandResponse.AuthResult = jwtToken;
                }
            }

            return userLoginCommandResponse;
        }
    }
}
