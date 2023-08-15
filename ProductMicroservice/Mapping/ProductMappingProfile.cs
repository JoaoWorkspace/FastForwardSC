using AutoMapper;
using FastForwardSC.Persistence.Models;
using Shared.Models;

namespace ProductMicroservice.Mapping
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile() {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
