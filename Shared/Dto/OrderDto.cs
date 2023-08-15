namespace Shared.Models
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public UserDto User { get; set; }
        public double Cost { get; set; }
        public ICollection<ProductDto> OrderProducts { get; set; } = new List<ProductDto>();
    }
}
