using System.ComponentModel.DataAnnotations;

namespace Empromel.API.Models
{
    public class Expenses
    {
        [Key]
        public Guid Id { get; set; }    

        [Required]
        [MaxLength(100)]    
        public string Description { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public float PricePaid { get; set; }

    }
}
