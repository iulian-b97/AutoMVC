using IdentityManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshTokenCommandResponse>
    {
        private readonly IUserRepository _userRepository;

        public RefreshTokenCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<RefreshTokenCommandResponse> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var refreshTokenCommandResponse = new RefreshTokenCommandResponse();

            var validator = new RefreshTokenCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                refreshTokenCommandResponse.Success = false;
                refreshTokenCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    refreshTokenCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (refreshTokenCommandResponse.Success)
            {
                var result = await _userRepository.VerifyAndGenerateToken(request.TokenRequest);

                if(result == null)
                {
                    refreshTokenCommandResponse.Success = false;
                }
                else
                {
                    refreshTokenCommandResponse.AuthResult = result;
                }
            }

            return refreshTokenCommandResponse;
        }
    }
}
