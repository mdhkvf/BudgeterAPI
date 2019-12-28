using AuthAPI.Payloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Services
{
    public interface IRegistrationService
    {
        public void Register(RegistrationPost registrationData);
        public DataTransfer.User CheckMatch(string username, string password);
    }
}
