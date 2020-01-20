using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAPI.Database;
using AuthAPI.DataTransfer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/income")]
    [ApiController]
    [Authorize]
    public class IncomeSourceController : ControllerBase
    {
        private IncomeSourceContext db = new IncomeSourceContext();

        [HttpPost]
        public IActionResult Post([FromBody] IncomeSource sourceData)
        {
            db.AddIncomeSource(sourceData);
            return Ok(sourceData);
        }
    }
}