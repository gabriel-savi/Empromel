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
            if (customer.Cpf == null || customer.Name == null || customer.BirthDate == DateTime.MinValue || customer.Gender == null || customer.Cep == null || customer.Street == null || customer.AddressNumber == 0
                || customer.City == null || customer.Uf == null)
                throw new Exception("Dados obrigatórios não informados corretamente!");

            Customer customerDb = _repository.GetCustomerByCpf(customer.Cpf);

            if (customerDb != null)
                throw new Exception("O cliente já existe na base de dados!");

            _repository.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }

        public Customer GetCustomerByCpf(string cpf)
        {
            if (cpf == null)
                throw new Exception("Número do CPF não informado!");

            if (cpf.Length != 11)
                throw new Exception("CPF inválido!");

            return _repository.GetCustomerByCpf(cpf);
        }

        public void UpdateCustomer(Customer customer)
        {

            Customer customerUp = _repository.GetCustomerByCpf(customer.Cpf);

            if (customerUp == null)
                throw new Exception("Esse cliente não existe!");

            if (customer.Cpf == null || customer.Name == null || customer.BirthDate == DateTime.MinValue || customer.Gender == null || customer.Cep == null || customer.Street == null || customer.AddressNumber == 0
                || customer.City == null || customer.Uf == null)
                throw new Exception("Dados obrigatórios não informados corretamente!");

            if (customer.Cpf.Length != 11 || customer.Cep.Length != 9)
                throw new Exception("Dados inválido!");

            _repository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(string cpf)
        {
            Customer customerDell = _repository.GetCustomerByCpf(cpf);

            if (customerDell == null)
                throw new Exception("CPF inserido inválido!");

            _repository.DeleteCustomer(customerDell);
        }
    }
}
