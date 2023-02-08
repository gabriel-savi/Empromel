using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empromel.API.Models
{
    public class SalesItems
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid SaleId { get; set; }

        [Required]
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [Required] 
        public int ItemAmount { get; set; }

        [Required]  
        public float ItemTotal { get; set; }
    }
}
