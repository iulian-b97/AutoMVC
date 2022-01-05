using IdentityManagement.Application.Contracts.Persistence;
using IdentityManagement.Application.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, AuthResult>
    {
        private readonly IUserRepository _userRepository;

        public RefreshTokenCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AuthResult> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var authResult = new AuthResult();
            var result = await _userRepository.VerifyAndGenerateToken(request.Token, request.RefreshToken);

            authResult = result;

            return authResult;
        }
    }
}
