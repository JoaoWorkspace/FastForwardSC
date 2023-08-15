using Shared.Models;

namespace Shared.Services
{
    public interface IStoreService
    {
        public Task<StoreDto> SearchStore(Guid storeId);
        public Task<StoreDto> CreateStore(StoreDto store);
        public Task<StoreDto> UpdateStore(StoreDto store);
        public Task RemoveStore(Guid storeId);
    }
}
