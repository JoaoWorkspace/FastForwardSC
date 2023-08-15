using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class RatingDto
    {
        public Guid ProductId { get; set; }
        public ProductDto Product { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public double Score { get; set; }
    }
}
