using FastForwardSC.Persistence.Models;

namespace EventMicroservice.Repositories
{
    public interface IEventRepository
    {
        public Task<Event> GetById(Guid eventId);
        public Task<Event> CreateEvent(Event evnt);
        public Task<Event> UpdatateEvent(Event evnt);
        public Task RemoveEvent(Guid eventId);
    }
}
