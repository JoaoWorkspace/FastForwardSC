using FastForwardSC.Persistence.Models;
using Shared.Models;
using Shared.Models.Enums;
using Shared.Services;

namespace ProductMicroservice
{
    public class ProductService : IProductService
    {
        public async Task<List<ProductDto>> SearchProductsByStore(Guid storeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> SearchProducts(string? category, string? brand, double? minPrice, double? maxPrice, SortBy sortBy)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> SearchProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> CreateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> UpdateProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}