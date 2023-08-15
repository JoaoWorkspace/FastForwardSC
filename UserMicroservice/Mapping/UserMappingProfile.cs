using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace UserMicroservice.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile() {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
