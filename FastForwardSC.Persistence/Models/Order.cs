using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastForwardSC.Persistence.Models
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [NotMapped]
        public double Cost { get { return Math.Round(this.OrderProducts.Select(product => product.Price).Sum(),2); } }
        public virtual ICollection<Product> OrderProducts { get; set; }
    }
}
