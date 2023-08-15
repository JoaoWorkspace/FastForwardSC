using Shared.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FastForwardSC.Persistence.Models
{
    public class Promotion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PromotionId { get; set; }
        [Required]
        public RedemptionType RedemptionType { get; set; }
        [Required]
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public DateTime PromotionExpiryDate { get; set; }
        public virtual ICollection<Product>? PromotionProducts { get; set; }
    }
}
