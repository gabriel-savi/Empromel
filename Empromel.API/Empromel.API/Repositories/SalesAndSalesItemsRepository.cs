using Empromel.API.Data.Context;
using Empromel.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Empromel.API.Repositories
{
    public class SalesAndSalesItemsRepository
    {
        private readonly DataContext _context;

        public SalesAndSalesItemsRepository(DataContext context)
        {
            _context = context;
        }

        public void AddSalesAndSalesItems(Sales sales, SalesItems salesItems)
        {
            _context.Sales.Add(sales);
            _context.SalesItems.Add(salesItems);
            _context.SaveChanges();

        }

        public List<Sales> GetAllSalesAndSaleItems()
        {
            return _context.Sales.Include(p => p.SalesItems).ToList();
        }

        public List<Sales> GetSalesAndSaleItemsByCustomer(string custormerId)
        {
            return _context.Sales.Include(p => p.SalesItems)
                                     .Where(p => p.CustomerId == custormerId)
                                     .ToList();
        }

        public void UpdateSalesAndSalesItems(Sales sales, SalesItems salesItems)
        {
            _context.Sales.Update(sales);
            _context.SalesItems.Update(salesItems);
            _context.SaveChanges();

        }

        public void DeleteSalesAndSalesItems(Sales sales, SalesItems salesItems)
        {

            _context.SalesItems.Remove(salesItems);
            _context.Sales.Remove(sales);
            _context.SaveChanges();

        }

    }
}
