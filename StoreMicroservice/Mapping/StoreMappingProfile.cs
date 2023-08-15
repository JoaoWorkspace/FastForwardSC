using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace StoreMicroservice.Mapping
{
    public class StoreMappingProfile : Profile
    {
        public StoreMappingProfile() {
            CreateMap<Store, StoreDto>().ReverseMap();
        }
    }
}
