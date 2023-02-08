using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empromel.API.Models
{
    public class Sales
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(11)]
        [ForeignKey("CustomerId")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]  
        public float SalesTotal { get; set; }

        [Required]  
        public DateTime SalesDate { get; set; } = DateTime.Now;

        [ForeignKey("SaleId")]
       public List<SalesItems> SalesItems { get; set; }

    }
}
