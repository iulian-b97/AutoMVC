using IdentityManagement.Application.Features.User.Queries.GetUser;
using IdentityManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMediator _mediator;

        public UserProfileController(UserManager<ApplicationUser> userManager, IMediator mediator)
        {
            _userManager = userManager;
            _mediator = mediator;
        }


        [HttpGet("userId")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<Object> GetUserId()
        {
            string userId = User.Claims.First(c => c.Type == "Id").Value;

            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.Id
            };
        }

        [HttpGet("userDetail")] 
        public async Task<IActionResult> GetUser(string userId)
        {
            var getUser = new GetUserQuery() { UserId = userId };

            var response = await _mediator.Send(getUser);
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("User doesn`t exist");
        }
    }
}

