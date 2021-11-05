using IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken;
using IdentityManagement.Application.Features.User.Commands.Login;
using IdentityManagement.Application.Features.User.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityManagement.Api.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register", Name = "Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationCommand userRegistrationCommand)
        {
            var response = await _mediator.Send(userRegistrationCommand);
            return Ok(response);
        }

        [HttpPost("login", Name = "Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginCommand userLoginCommand)
        {
            var response = await _mediator.Send(userLoginCommand);
            return Ok(response);
        }

        [HttpPost("refreshToken", Name = "RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenCommand refreshTokenCommand)
        {
            var response = await _mediator.Send(refreshTokenCommand);
            return Ok(response);
        }
    }
}
