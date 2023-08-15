using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastForwardSC.Persistence.Models
{
    public class Store
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StoreId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }
    }
}
