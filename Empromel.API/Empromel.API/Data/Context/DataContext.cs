using Empromel.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Empromel.API.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Expenses> Expenses { get; set; }
       
        public DbSet<Sales> Sales { get; set; }
      
        public DbSet<SalesItems> SalesItems { get; set; }
    }
}
