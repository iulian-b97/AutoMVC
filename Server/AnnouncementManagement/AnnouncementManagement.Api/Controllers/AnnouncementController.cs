using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateCarAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateMotorcycleAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTrailerAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateTruckAnnouncement;
using AnnouncementManagement.Application.Features.AnnouncementFeatures.Commands.CreateAnnouncement.CreateVanAnnouncement;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnnouncementManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("addCarAnnouncement", Name = "AddCarAnnouncement")]
        public async Task<IActionResult> AddCarAnnouncement([FromBody] CreateCarAnnouncementCommand createCarAnnouncementCommand)
        {
            var response = await _mediator.Send(createCarAnnouncementCommand);

            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Car announcement doesn`t exist.");
        }

        [HttpPost("addMotorcycleAnnouncement", Name = "AddMotorcycleAnnouncement")]
        public async Task<IActionResult> AddMotorcycleAnnouncement([FromBody] CreateMotorcycleAnnouncementCommand createMotorcycleAnnouncementCommand)
        {
            var response = await _mediator.Send(createMotorcycleAnnouncementCommand);

            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Motorcycle announcement doesn`t exist.");
        }

        [HttpPost("addTruckAnnouncement", Name = "AddTruckAnnouncement")]
        public async Task<IActionResult> AddTruckAnnouncement([FromBody] CreateTruckAnnouncementCommand createTruckAnnouncementCommand)
        {
            var response = await _mediator.Send(createTruckAnnouncementCommand);

            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Truck announcement doesn`t exist.");
        }

        [HttpPost("addVanAnnouncement", Name = "AddVanAnnouncement")]
        public async Task<IActionResult> AddVanAnnouncement([FromBody] CreateVanAnnouncementCommand createVanAnnouncementCommand)
        {
            var response = await _mediator.Send(createVanAnnouncementCommand);

            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Van announcement doesn`t exist.");
        }

        [HttpPost("addTrailerAnnouncement", Name = "AddTrailerAnnouncement")]
        public async Task<IActionResult> AddTrailerAnnouncement([FromBody] CreateTrailerAnnouncementCommand createTrailerAnnouncementCommand)
        {
            var response = await _mediator.Send(createTrailerAnnouncementCommand);

            if (response != null)
            {
                return Ok(response);
            }
            return BadRequest("Trailer announcement doesn`t exist.");
        }
    }
}
