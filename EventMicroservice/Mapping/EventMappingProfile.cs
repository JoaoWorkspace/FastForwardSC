using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace EventMicroservice.Mapping
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile() {
            CreateMap<Event, EventDto>().ReverseMap();
        }
    }
}
