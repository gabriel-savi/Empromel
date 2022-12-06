using Empromel.API.Models;
using Empromel.API.Repositories;

namespace Empromel.API.Services
{
    public class CustomersService
    {
        private readonly CustomersRepository _repository;

        public CustomersService(CustomersRepository repository)
        {
            _repository = repository;
        }

        public void AddCustomer(Customer customer)
        {
            if (customer.Cpf == null || customer.Name == null || customer.BirthDate == null || customer.Gender == null || customer.Cep == null || customer.Street == null || customer.AddressNumber == null ||
                || customer.City || customer.Uf)
                throw new Exception("Dados obrigatórios não informados corretamente!");
                
            Customer customerDb = _repository.GetCustomerByCpf(customer.Cpf);

            if(customerDb != null)
                throw new Exception("O cliente já existe na base de dados!");

            _repository.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }
    }
}
