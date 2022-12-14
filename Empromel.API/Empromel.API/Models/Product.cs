using System.ComponentModel.DataAnnotations;

namespace Empromel.API.Models
{
    public class Product
    {
        [Key]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(4)]
        public string Quantity { get; set; }

        [Required]
        public DataType Lot { get; set; }

        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(7)]
        public string Price_Paid { get; set; }

        [Required]
        [MaxLength(7)]
        public string Price_Charged { get; set; }

    }
}
