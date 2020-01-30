using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAPI.DataTransfer;
using AuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/expense")]
    [ApiController]
    [Authorize]
    public class ExpenseController : ControllerBase
    {
        private IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Expense expenseData)
        {
            int userId;
            if (int.TryParse(User.FindFirst("userId").Value, out userId))
            {
                expenseData.UserId = userId;
                expenseData.CategoryId = 1;
                _expenseService.AddExpense(expenseData);
                return Ok(expenseData);
            }
            return BadRequest();
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            int userId;
            if (int.TryParse(User.FindFirst("userId").Value, out userId))
            {
                var returnList = _expenseService.GetExpensesByUserId(userId);
                return Ok(returnList);
            }
            return BadRequest();
        }
    }
}