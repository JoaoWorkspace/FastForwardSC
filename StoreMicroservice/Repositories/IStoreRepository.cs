using FastForwardSC.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMicroservice.Repositories
{
    public interface IStoreRepository
    {
        public Task<Store> GetById(Guid storeId);
        public Task<Store> CreateStore(Store store);
        public Task<Store> UpdatateStore(Store store);
        public Task RemoveStore(Guid storeId);
    }
}
