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

        //private readonly JwtConfig _jwtConfig;
       //private readonly TokenValidationParameters _tokenValidationParams;

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
    }
}
