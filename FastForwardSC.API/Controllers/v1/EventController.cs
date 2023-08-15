using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared.Services;

namespace FastForwardSC.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;
        private readonly ILogger<UserController> _logger;

        public EventController(
            IEventService eventService,
            ILogger<UserController> logger)
        {
            this.eventService = eventService;
            _logger = logger;
        }

        [HttpGet("event/{eventId}")]
        public async Task<ActionResult<EventDto>> SearchEventAsync(string eventId)
        {
            var evnt = await this.eventService.SearchEvent(Guid.Parse(eventId));
            if (evnt == null)
            {
                return NotFound();
            }
            return this.Ok(eventId);
        }

        [HttpPost("event")]
        public async Task<ActionResult<EventDto>> CreateEventAsync(EventDto evnt)
        {
            try
            {
                var createdEvent = await this.eventService.CreateEvent(evnt);
                return this.Ok(createdEvent);
            }catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest("There was an issue creating a new event.");
            }
        }

        [HttpPut("event/{eventId}")]
        public async Task<ActionResult<EventDto>> UpdateEventAsync(string eventId, EventDto evnt)
        {
            try
            {
                evnt.EventId = Guid.Parse(eventId);
                var updatedEvent = await this.eventService.UpdateEvent(evnt);
                return this.Ok(updatedEvent);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest($"There was an issue updating event with id {eventId}");
            }
        }

        [HttpDelete("event/{eventId}")]
        public async Task<ActionResult> RemoveEventAsync(string eventId)
        {
            await this.eventService.RemoveEvent(Guid.Parse(eventId));
            return this.Ok("Removed Successfully");
        }
    }
}