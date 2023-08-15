using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<OrderDto>? UserOrderHistory { get; set; } = new List<OrderDto>();
        public ICollection<ProductDto>? UserCart { get; set; } = new List<ProductDto>();
        public ICollection<RatingDto>? UserRatings { get; set; } = new List<RatingDto>();
    }
}
