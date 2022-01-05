using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Application.Models;
using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.Login
{
    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommand, AuthResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;

        public UserLoginCommandHandler(UserManager<ApplicationUser> userManager,
            IUserRepository userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task<AuthResult> Handle(UserLoginCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser == null)
            {
                return null;
            }

            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, request.Password);
            if(!isCorrect)
            {
                return null;
            }

            var jwtToken = await _userRepository.GenerateJwtToken(existingUser);

            return jwtToken;
        }
    }
}
