using Shared.Models;

namespace Shared.Services
{
    public interface IEventService
    {
        public Task<EventDto> SearchEvent(Guid eventId);
        public Task<EventDto> CreateEvent(EventDto promotion);
        public Task<EventDto> UpdateEvent(EventDto promotion);
        public Task RemoveEvent(Guid eventId);
    }
}
