using Empromel.API.Models;
using Empromel.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Empromel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersService _customersService;

        public CustomersController(CustomersService customersService)
        {
            _customersService = customersService;
        }

        [Route("addcustomer")]
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customersService.AddCustomer(customer);
            return Ok();
        }

        [Route("getallcustomers")]
        [HttpPost]
        public IActionResult GetAllCustomers()
        {
            return Ok(_customersService.GetAllCustomers());
        }

        [Route("getcustomerbycpf/{cpf}")]
        [HttpPost]
        public IActionResult GetByCpf(string cpf)
        {
            return Ok(_customersService.GetCustomerByCpf(cpf));
        }

        [Route("updatecustomer")]
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _customersService.UpdateCustomer(customer);
            return Ok();
        }

        [Route("deletecustomer/{cpf}")]
        [HttpPost]
        public IActionResult DeleteCustomer(string cpf)
        {
            _customersService.DeleteCustomer(cpf);
            return Ok();
        }
    }
}
