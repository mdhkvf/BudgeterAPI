using AuthAPI.DataTransfer;
using AuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/income")]
    [ApiController]
    [Authorize]
    public class IncomeSourceController : ControllerBase
    {
        private IIncomeService _incomeServce;

        public IncomeSourceController(IIncomeService incomeService)
        {
            _incomeServce = incomeService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] IncomeSource sourceData)
        {
            _incomeServce.AddIncomeSource(sourceData);
            return Ok(sourceData);
        }

        [HttpGet("{userId}")]
        public IActionResult Get(int userId) 
        {
            var returnList = _incomeServce.GetIncomeSourcesById(userId);
            return Ok(returnList);
        }
    }
}