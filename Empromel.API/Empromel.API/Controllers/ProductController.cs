using Empromel.API.Models;
using Empromel.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Empromel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductsService _productsServices;

        public ProductController(ProductsService productsServices)
        {
            this._productsServices = productsServices;
        }

        [Route("addproduct")]
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productsServices.AddProduct(product);
            return Ok();
        }

        [Route("getallproduct")]
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return Ok(_productsServices.GetAllProducts());
        }

        [Route("getproductbyname/{name}")]
        [HttpGet]
        public IActionResult GetProductByName(string name)
        {
            return Ok(_productsServices.GetProductByName(name));
        }

        [Route("updateproduct")]
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productsServices.UpdateProduct(product);
            return Ok();
        }

        [Route("deleteproduct/{name}")]
        [HttpDelete]
        public IActionResult DeleteProduct(string name)
        {
            _productsServices.DeleteProduct(name);
            return Ok();
        }
    }
}
