using Shared.Models;
using Shared.Services;

namespace EventMicroservice
{
    public class EventService : IEventService
    {
        public async Task RegisterEvent(Guid userId, Guid eventId)
        {
            throw new NotImplementedException();
        }

        public async Task<EventDto> SearchEvent(Guid eventId)
        {
            throw new NotImplementedException();
        }

        public async Task<EventDto> CreateEvent(EventDto eventDto)
        {
            throw new NotImplementedException();
        }

        public async Task<EventDto> UpdateEvent(EventDto eventDto)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveEvent(Guid eventId)
        {
            throw new NotImplementedException();
        }
    }
}