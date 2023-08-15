using Shared.Models;

namespace Shared.Services
{
    public interface IPromotionService
    {
        public Task<PromotionDto> SearchPromotion(Guid promotionId);
        public Task<PromotionDto> CreatePromotion(PromotionDto promotion);
        public Task<PromotionDto> UpdatePromotion(PromotionDto promotion);
        public Task RemovePromotion(Guid promotionId);
    }
}
