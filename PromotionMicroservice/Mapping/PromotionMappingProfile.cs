using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace PromotionMicroservice.Mapping
{
    public class PromotionMappingProfile : Profile
    {
        public PromotionMappingProfile() {
            CreateMap<Promotion, PromotionDto>().ReverseMap();
        }
    }
}
