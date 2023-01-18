using Empromel.API.Models;
using Empromel.API.Repositories;

namespace Empromel.API.Services
{
    public class ProductsService
    {
        private readonly ProductsRepository _repository;

        public ProductsService(ProductsRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            if (product.Name == null || product.Quantity == null || product.Brand == null || product.PricePaid == 0
                || product.PriceCharged == 0)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");


            _repository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductByName(string name)
        {
           if(name == null)
                throw new Exception("Nome do produto inválido!");

           return _repository.GetProductByName(name);  
        }

        public void UpdateProduct(Product product)
        {
            Product productUp = _repository.GetProductById(product.Id);

            if (productUp == null)
                throw new Exception("Nome do produto inválido!");

            if (product.Name == null || product.Quantity == null || product.Brand == null || product.PricePaid == 0
                || product.PriceCharged == 0)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");

            _repository.UpdateProduct(product);
        }

        public void DeleteProduct(Guid id)
        {
            Product productDell = _repository.GetProductById(id);

            if (productDell == null)
                throw new Exception("Nome do produto inválido!");

            _repository.DeleteProduct(productDell);

        }
    }
}
