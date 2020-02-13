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
        public IActionResult Post([FromBody] Income sourceData)
        {
            int userId;            
            if (int.TryParse(User.FindFirst("userId").Value, out userId))
            {
                sourceData.UserId = userId;
                _incomeServce.AddIncomeSource(sourceData);
                return Ok(sourceData);
            }
            return BadRequest();
        }

        [HttpGet("")]
        public IActionResult Get() 
        {
            int userId;
            if (int.TryParse(User.FindFirst("userId").Value, out userId))
            {
                var returnList = _incomeServce.GetIncomeSourcesById(userId);
                return Ok(returnList);
            }
            return BadRequest();
        }
    }
}