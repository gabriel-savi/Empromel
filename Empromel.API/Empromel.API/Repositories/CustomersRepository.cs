using Empromel.API.Data.Context;
using Empromel.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Empromel.API.Repositories
{
    public class CustomersRepository
    {
        private readonly DataContext _context;

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerByCpf(string cpf)
        {
            return _context.Customers.AsNoTracking().ToList().FirstOrDefault(c => c.Cpf == cpf);
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
