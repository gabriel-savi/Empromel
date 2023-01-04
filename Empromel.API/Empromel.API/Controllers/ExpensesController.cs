using Empromel.API.Models;
using Empromel.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Empromel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly ExpensesService _expensesService;

        public ExpensesController(ExpensesService expensesService)
        {
            _expensesService = expensesService;
        }


        [HttpPost]
        [Route("addexpenses")]
        public IActionResult AddExpenses(Expenses expenses)
        {
            _expensesService.AddExpenses(expenses);
            return Ok();
        }

        [HttpGet]
        [Route("getallexpenses")]
        public IActionResult GetAllExpenses()
        {
            
            return Ok(_expensesService.GetAllExpenses());
        }

        [HttpGet]
        [Route("getexpensesbydescription{description}")]
        public IActionResult GetExpensesByDescription(string description)
        {

            return Ok(_expensesService.GetExpensesByDescription(description));
        }

        [HttpPut]
        [Route("updateexpenses")]
        public IActionResult UpdateExpenses(Expenses expenses)
        {
            _expensesService.UpdateExpenses(expenses);
            return Ok();
        }

        [HttpDelete]
        [Route("deleteexpenses{description}")]
        public IActionResult DeleteExpenses(string description)
        {
            _expensesService.DeleteteExpenses(description);
            return Ok();
        }

    }
}
