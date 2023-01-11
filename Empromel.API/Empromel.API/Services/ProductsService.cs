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
            if (product.Name == null || product.Quantity == null || product.Brand == null || product.PricePaid == null
                || product.PriceCharged == null)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");

            Product productDb = _repository.GetProductByName(product.Name);

            if (productDb != null)
                throw new Exception("Produto já inserido no banco de dados!");

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
            Product productUp = _repository.GetProductByName(product.Name);

            if (productUp == null)
                throw new Exception("Nome do produto inválido!");

            if (product.Name == null || product.Quantity == null || product.Brand == null || product.PricePaid == null
                || product.PriceCharged == null)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");

            _repository.UpdateProduct(product);
        }

        public void DeleteProduct(string name)
        {
            Product productDell = _repository.GetProductByName(name);

            if (productDell == null)
                throw new Exception("Nome do produto inválido!");

            _repository.DeleteProduct(productDell);

        }
    }
}
