using IdentityManagement.Application.Features.User.Commands.GenerateRefreshToken;
using IdentityManagement.Application.Features.User.Commands.Login;
using IdentityManagement.Application.Features.User.Commands.Register;
using IdentityManagement.Application.Models;
using IdentityManagement.Domain.Entities;
using IdentityManagement.Infrastructure.Persistence;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityManagement.Api.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            _mediator = mediator;
        }

        [HttpPost("register", Name = "Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationCommand userRegistrationCommand)
        {
            var response = await _mediator.Send(userRegistrationCommand);
            if(response.Success)
            {
                return Ok(response);
            }
            return BadRequest("User could not be created.");
        }

        
        [HttpPost("login", Name = "Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginCommand userLoginCommand)
        {
            var response = await _mediator.Send(userLoginCommand);
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Email or password is invalid.");
        } 

        [HttpPost("refreshToken", Name = "RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenCommand refreshTokenCommand)
        {
            var response = await _mediator.Send(refreshTokenCommand);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest("Token could not be created.");
        }
    }
}
