using Empromel.API.Data.Context;
using Empromel.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Empromel.API.Repositories
{
    public class ExpensesRepository
    {
        private readonly DataContext _context;

        public ExpensesRepository(DataContext context)
        {
            _context = context;
        }

        public void AddExpenses(Expenses expenses)
        {
            _context.Expenses.Add(expenses);
            _context.SaveChanges();
        }

        public List<Expenses>GetAllExpenses()
        {
            return _context.Expenses.ToList();
        }

        public Expenses GetExpensesByDescription(string description)
        {
            return _context.Expenses.FirstOrDefault(p => p.Description == description);
        }

        public void UpdateExpenses(Expenses expenses)
        {
            _context.Expenses.Update(expenses);
            _context.SaveChanges();
        }

        public void DeleteExpenses(Expenses expenses)
        {
            _context.Expenses.Remove(expenses);
            _context.SaveChanges();
        }

    }
}
