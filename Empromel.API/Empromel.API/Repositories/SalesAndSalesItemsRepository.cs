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
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Sales.Add(sales);
                _context.SalesItems.Add(salesItems);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
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
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Sales.Update(sales);
                _context.SalesItems.Update(salesItems);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }

        public void DeleteSalesAndSalesItems(Sales sales, SalesItems salesItems)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Sales.Remove(sales);
                _context.SalesItems.Remove(salesItems);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }

        }

    }
}
