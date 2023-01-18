using Empromel.API.Models;
using Empromel.API.Repositories;

namespace Empromel.API.Services
{
    public class ExpensesService
    {
        private readonly ExpensesRepository _expensesRepository;

        public ExpensesService(ExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        public void AddExpenses(Expenses expenses)
        {

            if (expenses.Description == null || expenses.PricePaid == 0 || expenses.PurchaseDate == DateTime.MinValue)
                throw new Exception("Dados obrigatório inseridos incorretamente!");


            _expensesRepository.AddExpenses(expenses);
        }

        public List<Expenses> GetAllExpenses()
        {
            return _expensesRepository.GetAllExpenses();
        }

        public Expenses GetExpensesByDescription(string description)
        {
            if (description == null)
                throw new Exception("Despesa não cadastrada!");

            return _expensesRepository.GetExpensesByDescription(description);
        }

        public void UpdateExpenses(Expenses expenses)
        {
            Expenses expensesUp = _expensesRepository.GetExpensesById(expenses.Id);
            if (expensesUp == null)
                throw new Exception("Despesa não cadastrada!");

            if (expenses.Description == null || expenses.PricePaid == 0 || expenses.PurchaseDate == DateTime.MinValue)
                throw new Exception("Dados obrigatório inseridos incorretamente!");

            _expensesRepository.UpdateExpenses(expenses);
        }

        public void DeleteteExpenses(Guid id)
        {
            Expenses expensesDell = _expensesRepository.GetExpensesById(id);
            if (expensesDell == null)
                throw new Exception("Despesa não cadastrada!");

            _expensesRepository.DeleteExpenses(expensesDell);
        }

    }
}
