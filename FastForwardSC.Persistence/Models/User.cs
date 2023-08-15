using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastForwardSC.Persistence.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Active { get; set; } = true;


        public virtual ICollection<Order>? UserOrderHistory { get; set; }
        public virtual ICollection<Product>? UserCart { get; set; }
        public virtual ICollection<Rating>? UserRatings { get; set; }

    }
}
