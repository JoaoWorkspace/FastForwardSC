using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public Guid StoreId { get; set; }
        public StoreDto Store { get; set; }
        public ICollection<RatingDto> ProductRatings { get; set; } = new List<RatingDto>();
    }
}
