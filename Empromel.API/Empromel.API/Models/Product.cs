using System.ComponentModel.DataAnnotations;

namespace Empromel.API.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(4)]
        public string Quantity { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(7)]
        public string PricePaid { get; set; }

        [Required]
        [MaxLength(7)]
        public string PriceCharged { get; set; }

    }
}
