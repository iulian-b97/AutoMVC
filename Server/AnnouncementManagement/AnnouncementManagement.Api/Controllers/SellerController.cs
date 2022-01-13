using AnnouncementManagement.Application.Features.SellerProfile.Commands.AddSellerProfile;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnouncementManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SellerController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("createSeller", Name = "CreateSeller")]
        public async Task<IActionResult> CreateSeller([FromBody] CreateSellerCommand createSellerCommand)
        {
            var response = await _mediator.Send(createSellerCommand);
            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Seller doesn`t exist.");
        }
    }
}
