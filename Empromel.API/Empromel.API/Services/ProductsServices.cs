using Empromel.API.Models;
using Empromel.API.Repositories;

namespace Empromel.API.Services
{
    public class ProductsServices
    {
        private readonly ProductsRepository _repository;

        public ProductsServices(ProductsRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            if (product.Name == null || product.Quantity == null || product.Lot == null || product.Brand == null || product.Price_Paid == null
                || product.Price_Charged == null)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");

            Product productnew = _repository.GetProductByName(product.Name);

            if (productnew != null)
                throw new Exception("Produto já inserido no banco de dados!");
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

            if (product.Name == null || product.Quantity == null || product.Lot == null || product.Brand == null || product.Price_Paid == null
                || product.Price_Charged == null)
                throw new Exception("Dados obrigatorios não inseridos corretamente!");
            _repository.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            Product productDell = _repository.GetProductByName(product.Name);

            if (productDell == null)
                throw new Exception("Nome do produto inválido!");
            _repository.DeleteProduct(product);

        }
    }
}
