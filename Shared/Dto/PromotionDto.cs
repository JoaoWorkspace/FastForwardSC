using Shared.Models.Enums;

namespace Shared.Models
{
    public class PromotionDto
    {
        public Guid PromotionId { get; set; }
        public RedemptionType RedemptionType { get; set;}
    }
}
