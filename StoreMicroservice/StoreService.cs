using FastForwardSC.Persistence.Models;
using Shared.Models;
using Shared.Services;

namespace StoreMicroservice
{
    public class StoreService : IStoreService
    {
        public async Task<StoreDto> SearchStore(Guid storeId)
        {
            throw new NotImplementedException();
        }

        public async Task<StoreDto> CreateStore(StoreDto store)
        {
            throw new NotImplementedException();
        }

        public async Task<StoreDto> UpdateStore(StoreDto store)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveStore(Guid storeId)
        {
            throw new NotImplementedException();
        }
    }
}