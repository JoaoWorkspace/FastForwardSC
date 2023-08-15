using Shared.Models;
using Shared.Models.Enums;
using Shared.Services;

namespace PromotionMicroservice
{
    public class PromotionService : IPromotionService
    {
        public async Task<List<PromotionDto>> GetAllPromotions()
        {
            throw new NotImplementedException();
        }

        public async Task<List<PromotionDto>> SearchPromotionByStore(Guid storeId)
        {
            throw new NotImplementedException();
        }

        public async Task<PromotionDto> SearchPromotion(Guid promotionId)
        {
            throw new NotImplementedException();
        }

        public async Task<PromotionDto> CreatePromotion(PromotionDto promotion)
        {
            throw new NotImplementedException();
        }

        public async Task<PromotionDto> UpdatePromotion(PromotionDto promotion)
        {
            throw new NotImplementedException();
        }

        public async Task RedeemPromotion(RedemptionType redemptionType, Guid storeId)
        {
            throw new NotImplementedException();
        }

        public async Task RemovePromotion(Guid promotionId)
        {
            throw new NotImplementedException();
        }
    }
}