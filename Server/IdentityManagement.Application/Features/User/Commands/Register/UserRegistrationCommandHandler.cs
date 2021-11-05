using AutoMapper;
using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Register
{
    public class UserRegistrationCommandHandler : IRequestHandler<UserRegistrationCommand, UserRegistrationCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRegistrationCommandHandler(IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
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
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Country = request.Country
                };
                var user = await _userManager.CreateAsync(newUser, request.Password);
            }

            return userRegistrationCommandResponse;
        }
    }
}
