using Shared.Models;

namespace Shared.Services
{
    public interface IProductService
    {
        public Task<ProductDto> SearchProduct(Guid productId);
        public Task<ProductDto> CreateProduct(ProductDto product);
        public Task<ProductDto> UpdateProduct(ProductDto product);
        public Task RemoveProduct(Guid productId);
    }
}
