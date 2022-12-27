using System.ComponentModel.DataAnnotations;

namespace Empromel.API.Models
{
    public class Customer
    {
        [Key]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(12)]
        public string Phone { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
        
        [MaxLength(1)]
        [Required]
        public string Gender { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(9)]
        [Required]
        public string Cep { get; set; }

        [MaxLength(200)]
        [Required]
        public string Street { get; set; }

        [MaxLength(4)]
        [Required]
        public int AddressNumber { get; set; }

        [MaxLength(50)]
        public string AddressSupplement  { get; set; }

        [MaxLength(150)]
        [Required]
        public string City { get; set; }

        [MaxLength(2)]
        [Required]
        public string Uf { get; set; }
    }
}
