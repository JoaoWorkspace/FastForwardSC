using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace RatingMicroservice.Mapping
{
    public class RatingMappingProfile : Profile
    {
        public RatingMappingProfile() {
            CreateMap<Rating, RatingDto>().ReverseMap();
        }
    }
}
