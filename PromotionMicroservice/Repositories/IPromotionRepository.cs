using FastForwardSC.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionMicroservice.Repositories
{
    public interface IPromotionRepository
    {
        public Task<Promotion> GetById(Guid promotionId);
        public Task<Promotion> CreatePromotion(Promotion promotion);
        public Task<Promotion> UpdatatePromotion(Promotion promotion);
        public Task RemovePromotion(Guid promotionId);
    }
}
