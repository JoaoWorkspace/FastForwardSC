using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FastForwardSC.Persistence.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProdutId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public Guid StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public virtual ICollection<Rating>? ProductRatings { get; set; }
    }
}
