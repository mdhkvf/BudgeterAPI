using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAPI.Payloads;
using AuthAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        private readonly IAuthenticationService _authService;

        public LoginController(IRegistrationService registrationService, IAuthenticationService authService)
        {
            _registrationService = registrationService;
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginPost loginData)
        {
            LoginPostResponse response = new LoginPostResponse();

            DataTransfer.User matchedUser = _registrationService.CheckMatch(loginData.UserName, loginData.Password);

            if (matchedUser != null)
            {
                response.Success = true;
                response.Body = new LoginPostResponseBody()
                {
                    UserName = matchedUser.UserName,
                    EmailAddress = matchedUser.EmailAddress,
                    FirstName = matchedUser.FirstName,
                    LastName = matchedUser.LastName,
                    AuthToken = _authService.GetToken()
                };
            }
            else
            {
                response.Success = false;
                response.ErrorMessage = "Invalid username or password.";
            }
            return Ok(response);
        }
    }
}