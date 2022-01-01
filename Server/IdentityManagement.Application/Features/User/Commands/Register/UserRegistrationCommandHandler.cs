using AutoMapper;
using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Register
{
    public class UserRegistrationCommandHandler : IRequestHandler<UserRegistrationCommand, UserRegistrationCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;

        public UserRegistrationCommandHandler(IMapper mapper, 
            UserManager<ApplicationUser> userManager,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task<UserRegistrationCommandResponse> Handle(UserRegistrationCommand request, CancellationToken cancellationToken)
        {
            var userRegistrationCommandResponse = new UserRegistrationCommandResponse();

            var validator = new UserRegistrationCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                userRegistrationCommandResponse.Success = false;
                userRegistrationCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    userRegistrationCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if(userRegistrationCommandResponse.Success)
            {
                var newUser = new ApplicationUser()
                {
                    UserName = request.UserName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Country = request.Country
                };
                var isCreated = await _userManager.CreateAsync(newUser, request.Password);
                if (isCreated.Succeeded)
                {
                    var jwtToken = await _userRepository.GenerateJwtToken(newUser);
                    userRegistrationCommandResponse.AuthResult = jwtToken;
                }
            }

            return userRegistrationCommandResponse;
        }
    }
}
