using FastForwardSC.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> GetById(Guid productId);
        public Task<Product> CreateProduct(Product product);
        public Task<Product> UpdatateProduct(Product product);
        public Task RemoveProduct(Guid productId);
    }
}
