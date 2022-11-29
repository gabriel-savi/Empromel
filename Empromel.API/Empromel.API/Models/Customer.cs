using System.ComponentModel.DataAnnotations;

namespace Empromel.API.Models
{
    public class Customer
    {
        [Key]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(12)]
        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }
        
        [MaxLength(1)]
        public string Gender { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(9)]
        public string Cep { get; set; }

        [MaxLength(200)]
        public string Street { get; set; }

        [MaxLength(4)]
        public int AddressNumber { get; set; }

        [MaxLength(50)]
        public string AddressSupplement  { get; set; }

        [MaxLength(150)]
        public string City { get; set; }

        [MaxLength(2)]
        public string Uf { get; set; }
    }
}
