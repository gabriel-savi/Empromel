using Empromel.API.Models;
using Empromel.API.Repositories;

namespace Empromel.API.Services
{
    public class SalesAndSalesItemsService
    {
        private readonly SalesAndSalesItemsRepository _repository;

        public SalesAndSalesItemsService (SalesAndSalesItemsRepository repository)
        {
            _repository = repository;
        }

        public void AddSalesAndSalesItems (Sales sales, SalesItems salesItems)
        {
            
        }
    }
}

